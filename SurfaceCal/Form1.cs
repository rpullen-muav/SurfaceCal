using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// <copyright file="Form1.cs + ServoData.cs" company="Martin UAV">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
// <author>Ryan Pullen</author>
// <date>04/13/2020 16:21:00 PM </date>
// <summary>Servo Calibration Tool</summary>

namespace SurfaceCal
{
    public partial class Form1 : Form
    {
        // set up objects
        public ServoData Servo1;
        public ServoData Servo2;
        public ServoData Servo3;
        public ServoData Servo4;
        public ServoData Servo5;
        public ServoData Servo6;
        public ServoData Servo7;
        public ServoData Servo8;
        public ServoData Servo9;
        public ServoData Servo10;
        public List<ServoData> Servos = new List<ServoData>();
        public List<TextBox> PwmM;
        public List<TextBox> PwmMA;
        public List<Button> ServoButtons;
        public ChartArea chart;
        public int Started = 1;
        public int CurrentServo = -1;

        public int[] ServoTabStatus = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();

            // Setup pwm list objects
            PwmM = new List<TextBox>() { txtAn30Pwm,
                                         txtA0Pwm,
                                         txtA30Pwm,
                                        };

            PwmMA = new List<TextBox>() { txtAn30Pwm,
                                          txtA0Pwm,
                                          txtA30Pwm
                                        };

            ServoButtons = new List<Button>() { btnV1,
                                                btnV2,
                                                btnV3,
                                                btnV4,
                                                btnV5,
                                                btnV6,
                                                btnV7,
                                                btnV8,
                                                btnAilL,
                                                btnAilR
                                                };
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Make sure our ecosystem gets created
            if (!CalData.IsDir("d", "Suspended_Cal_Data"))  // if it doesn't exist, create
            {
                Directory.CreateDirectory("Suspended_Cal_Data");
            }
            if (!CalData.IsDir("d", "Archived_Cal_Data"))  // if it doesn't exist, create
            {
                Directory.CreateDirectory("Archived_Cal_Data");
            }
            if (!CalData.IsDir("d", "Completed_Calibrations"))  // if it doesn't exist, create
            {
                Directory.CreateDirectory("Completed_Calibrations");
            }
        }

        /**********************************************************************************************************************/
        /********************************* start button handlers **************************************************************/
        /**********************************************************************************************************************/

        // single servo validation
        private void btnValidateServo_Click(object sender, EventArgs e)
        {
            if (CurrentServo == -1)
            {
                MessageBox.Show("A Servo button bmust be selected in order to validate");
                return;
            }
            ValidateServo();
        }

        // loads data of servo button when clicked
        public void btnV1_Click(object sender, EventArgs e)
        {
            ClearPage();
            EnableServoFields();
            Button servoBtn = ((Button)sender);
            Debug.WriteLine(servoBtn.Name);
            servoBtn.BackColor = Color.Yellow;
            servoBtn.ForeColor = Color.Black;
            switch (servoBtn.Name)
            {
                // button 1 is coomented in detail, same for the other 9 servo buttons
                case "btnV1":
                    CurrentServo = 1;
                    // if the servo has no data
                    if (Servo1 == null)
                    {
                        // create servo object
                        Servo1 = new ServoData()
                        {
                            // position specific data
                            Name = "Servo1",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV1",
                            isValidated = false,
                            // v = Vane, A = Aileron
                            ServoType = "V"
                        };
                        // start list to hold measured pwm values 
                        Servo1.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        // resets field color if different file is loaded and there is no data for this servo
                        ResetFieldColor();
                        // servo fields are enabled if servo data hasnt been populated
                        EnableServoFields();
                        // Add servo to list for further processing
                        Servos.Add(Servo1);
                        // Show some progress in the output monitor
                        Debug.WriteLine($"Created Servo 1");
                    }
                    // if the servo has data
                    else
                    {
                        // Loads servo data into table for viewing
                        for (int i = 0; i < Servo1.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo1.VanePwmRealList[i].ToString();
                        }
                        if (Servo1.isValidated == true)
                        {
                            // change background colors if valid
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            // disable fields so accidental manipulation doesnt occur
                            DisableServoFields();
                        }
                        // display numbers and grapg data
                        PrepareVane(PwmM, Servo1);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV2":
                    CurrentServo = 2;
                    if (Servo2 == null)
                    {
                        Servo2 = new ServoData()
                        {
                            Name = "Servo2",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV2",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo2.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo2);
                        Debug.WriteLine($"Created Servo 2");
                    }
                    else
                    {
                        for (int i = 0; i < Servo2.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo2.VanePwmRealList[i].ToString();
                        }
                        if (Servo2.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo2);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV3":
                    CurrentServo = 3;
                    if (Servo3 == null)
                    {
                        Servo3 = new ServoData()
                        {
                            Name = "Servo3",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV3",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo3.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo3);
                        Debug.WriteLine($"Created Servo 3");
                    }
                    else
                    {
                        for (int i = 0; i < Servo3.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo3.VanePwmRealList[i].ToString();
                        }
                        if (Servo3.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo3);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV4":
                    CurrentServo = 4;
                    if (Servo4 == null)
                    {
                        Servo4 = new ServoData()
                        {
                            Name = "Servo4",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV4",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo4.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo4);
                        Debug.WriteLine($"Created Servo 4");
                    }
                    else
                    {
                        for (int i = 0; i < Servo4.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo4.VanePwmRealList[i].ToString();
                        }
                        if (Servo4.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo4);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV5":
                    CurrentServo = 5;
                    if (Servo5 == null)
                    {
                        Servo5 = new ServoData()
                        {
                            Name = "Servo5",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV5",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo5.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo5);
                        Debug.WriteLine($"Created Servo 5");
                    }
                    else
                    {
                        for (int i = 0; i < Servo5.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo5.VanePwmRealList[i].ToString();
                        }
                        if (Servo5.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo5);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV6":
                    CurrentServo = 6;
                    if (Servo6 == null)
                    {
                        Servo6 = new ServoData()
                        {
                            Name = "Servo6",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV6",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo6.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo6);
                        Debug.WriteLine($"Created Servo 6");
                    }
                    else
                    {
                        for (int i = 0; i < Servo6.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo6.VanePwmRealList[i].ToString();
                        }
                        if (Servo6.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo6);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV7":
                    CurrentServo = 7;
                    if (Servo7 == null)
                    {
                        Servo7 = new ServoData()
                        {
                            Name = "Servo7",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV7",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo7.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo7);
                        Debug.WriteLine($"Created Servo 7");
                    }
                    else
                    {
                        for (int i = 0; i < Servo7.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo7.VanePwmRealList[i].ToString();
                        }
                        if (Servo7.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo7);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnV8":
                    CurrentServo = 8;
                    if (Servo8 == null)
                    {
                        Servo8 = new ServoData()
                        {
                            Name = "Servo8",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnV8",
                            isValidated = false,
                            ServoType = "V"
                        };
                        Servo8.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        EnableServoFields();
                        Servos.Add(Servo8);
                        Debug.WriteLine($"Created Servo 8");
                    }
                    else
                    {
                        for (int i = 0; i < Servo8.VanePwmRealList.Count; i++)
                        {
                            PwmM[i].Text = Servo8.VanePwmRealList[i].ToString();
                        }
                        if (Servo8.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareVane(PwmM, Servo8);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnAilL":
                    CurrentServo = 9;
                    if (Servo9 == null)
                    {
                        Servo9 = new ServoData()
                        {
                            Name = "Servo9",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnAilL",
                            isValidated = false,
                            ServoType = "A"
                        };
                        Servo9.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        Servos.Add(Servo9);
                        Debug.WriteLine($"Created Servo 9");
                    }
                    else
                    {
                        for (int i = 0; i < Servo9.VanePwmRealList.Count; i++)
                        {
                            PwmMA[i].Text = Servo9.VanePwmRealList[i].ToString();
                        }
                        if (Servo9.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareAileron(PwmMA, Servo9);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
                case "btnAilR":
                    CurrentServo = 10;
                    if (Servo10 == null)
                    {
                        Servo10 = new ServoData()
                        {
                            Name = "Servo10",
                            TabStatus = 1,
                            ServoNumber = CurrentServo,
                            ServoBtnName = "btnAilR",
                            isValidated = false,
                            ServoType = "A"
                        };
                        Servo10.VanePwmRealList = new List<double>() { 0, 0, 0 };
                        ResetFieldColor();
                        Servos.Add(Servo10);
                        Debug.WriteLine($"Created Servo 10");
                    }
                    else
                    {
                        for (int i = 0; i < Servo10.VanePwmRealList.Count; i++)
                        {
                            PwmMA[i].Text = Servo10.VanePwmRealList[i].ToString();
                        }
                        if (Servo10.isValidated == true)
                        {
                            servoBtn.BackColor = Color.Green;
                            servoBtn.ForeColor = Color.White;
                            FieldColorValidated();
                            DisableServoFields();
                        }
                        PrepareAileron(PwmMA, Servo10);
                        Debug.WriteLine($"Servo {CurrentServo} already exists");
                    }
                    break;
            }
        }

        public void suscal()
        {
            // no servo data has been entered
            if (Servos.Count < 1)
            {
                MessageBox.Show("At least one table must be completed in order to suspend cal");
                return;
            }
            else
            {
                foreach (var item in Servos)
                {
                    // save each complete servo, incomplete servo cals will be discarded
                    if (!item.isValidated)
                    {
                        MessageBox.Show("Servo tables must pass validation before they can be suspended");
                        return;
                    }
                }
            }

            // must pass validation to suspend
            if (!ReadyForGen(txtPID, txtTailNumber, Servos)) return;

            SuspendCal sc = new SuspendCal();

            sc.PID = txtPID.Text;
            sc.SN = txtTailNumber.Text;
            sc.Timestamp = DateTime.Now.ToString("yyyyMMdd_hhmm");
            sc.ServoList = new List<ServoData>(Servos);

            CalData.SaveCal(sc, false);
        }

        // suspend cal for work stoppage
        private void btnSuspendCal_Click(object sender, EventArgs e)
        {
            suscal();
        }

        // validate all servos, warn if missing servo data
        private void btnValidateAll_Click(object sender, EventArgs e)
        {
            if (!CheckServoData(PwmM)) return;
            if (!ReadyForGen(txtPID, txtTailNumber, Servos, true)) return;
            EnableParamButton();
        }

        // unlock in case of needed modification
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DisableParamButton();
            Debug.WriteLine(CurrentServo);
            switch (CurrentServo)
            {
                case 1:
                    // changes completed flag, and enable fields for data correction
                    UnlockTab(Servo1, btnV1);
                    break;
                case 2:
                    UnlockTab(Servo2, btnV2);
                    break;
                case 3:
                    UnlockTab(Servo3, btnV3);
                    break;
                case 4:
                    UnlockTab(Servo4, btnV4);
                    break;
                case 5:
                    UnlockTab(Servo5, btnV5);
                    break;
                case 6:
                    UnlockTab(Servo6, btnV6);
                    break;
                case 7:
                    UnlockTab(Servo7, btnV7);
                    break;
                case 8:
                    UnlockTab(Servo8, btnV8);
                    break;
                case 9:
                    UnlockTab(Servo9, btnAilL);
                    break;
                case 10:
                    UnlockTab(Servo10, btnAilR);
                    break;
            }

        }

        // Load a suspended cal
        private void btdLoadCal_Click(object sender, EventArgs e)
        {
            // cal was just loaded, a full validation must occur to enable this button
            DisableParamButton();
            // load suspended cal
            SuspendCal Data = (CalData.LoadCal(openFileDialog1));
            // if cal is empty, do nothing
            if (Data.ServoList == null) return;
            // clear data for new incoming data
            Servos.Clear();
            ClearPage();
            ChangeSevoButtonColorRed();
            Servos = new List<ServoData>();
            // load PID and tail number
            txtPID.Text = Data.PID;
            txtTailNumber.Text = Data.SN;
            foreach (var item in Data.ServoList)
            {
                Debug.WriteLine($"When Load button is pushed its {item.VanePwmRealList.Count} long");

                switch (item.ServoBtnName)
                {
                    // load servo data, take appropriate action if data is valid or not
                    case "btnV1":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo1 = new ServoData();
                        Servo1 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json);
                        Servos.Add(Servo1);
                        break;
                    case "btnV2":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo2 = new ServoData();
                        Servo2 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json2);
                        Servos.Add(Servo2);
                        break;
                    case "btnV3":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json3 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo3 = new ServoData();
                        Servo3 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json3);
                        Servos.Add(Servo3);
                        break;
                    case "btnV4":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json4 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo4 = new ServoData();
                        Servo4 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json4);
                        Servos.Add(Servo4);
                        break;
                    case "btnV5":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json5 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo5 = new ServoData();
                        Servo5 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json5);
                        Servos.Add(Servo5);
                        break;
                    case "btnV6":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json6 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo6 = new ServoData();
                        Servo6 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json6);
                        Servos.Add(Servo6);
                        break;
                    case "btnV7":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json7 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo7 = new ServoData();
                        Servo7 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json7);
                        Servos.Add(Servo7);
                        break;
                    case "btnV8":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json8 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo8 = new ServoData();
                        Servo8 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json8);
                        Servos.Add(Servo8);
                        break;
                    case "btnAilL":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json9 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo9 = new ServoData();
                        Servo9 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json9);
                        Servos.Add(Servo9);
                        break;
                    case "btnAilR":
                        if (item.isValidated == true)
                        {
                            IsValidated(item.ServoBtnName);
                        }
                        string json10 = Newtonsoft.Json.JsonConvert.SerializeObject(item);
                        Servo10 = new ServoData();
                        Servo10 = Newtonsoft.Json.JsonConvert.DeserializeObject<ServoData>(json10);
                        Servos.Add(Servo10);
                        break;
                }
            }
        }

        // if all data checks good, create params and send to folder
        private void btnGenerateParams_Click(object sender, EventArgs e)
        {
            // reorder servos to be mapped correctly for aircraft
            List<ServoData> ReOrdered = new List<ServoData>()
            {
                Servo1,Servo5,Servo2,Servo6,Servo3,Servo7,Servo4,Servo8
            };
            int[] ServoOrder = { 1, 5, 2, 6, 3, 7, 4, 8 };
            List<double> holdervals = new List<double>();
            RootObject DataOut = new RootObject();
            // populate data fields
            DataOut.changes.vane_bias_pwm = new List<double>();
            DataOut.changes.vane_deg_to_pwm = new List<double>();
            DataOut.changes.vane_max_pwm = new List<double>();
            DataOut.changes.vane_min_pwm = new List<double>();
            DataOut.changes.flap_bias_pwm = new List<double>();
            DataOut.changes.flap_deg_to_pwm = new List<double>();
            DataOut.changes.flap_max_pwm = new List<double>();
            DataOut.changes.flap_min_pwm = new List<double>();
            DataOut.changes.max_deflection_deg = new List<double>();

            // use lowest max aileron value for top end
            if (Servo9.VanePwmMax < Servo10.VanePwmMax)
            {
                DataOut.changes.flap_max_pwm.Add(Servo9.VanePwmMax);
            }
            else
            {
                DataOut.changes.flap_max_pwm.Add(Servo10.VanePwmMax);
            }

            // use highest min aileron value to bottom end
            if (Servo9.VanePwmMin > Servo10.VanePwmMin)
            {
                DataOut.changes.flap_min_pwm.Add(Servo9.VanePwmMin);
            }
            else
            {
                DataOut.changes.flap_min_pwm.Add(Servo10.VanePwmMin);
            }

            double bias1 = Math.Abs(1500 - Servo9.VanePwmBias);
            double bias2 = Math.Abs(1500 - Servo10.VanePwmBias);
            double AverageFlapTravel = 35;

            // take the bias closer to 1500 uS
            if (bias1 < bias2)
            {
                DataOut.changes.flap_bias_pwm.Add(Servo9.VanePwmBias);
            }
            else
            {
                DataOut.changes.flap_bias_pwm.Add(Servo10.VanePwmBias);
            }
            // find aileron deg-to-pwm
            DataOut.changes.flap_deg_to_pwm.Add((DataOut.changes.flap_max_pwm[0] - DataOut.changes.flap_min_pwm[0]) / AverageFlapTravel);


            List<double> MaxDeflections = new List<double>();

            Debug.WriteLine($"Reordered is {ReOrdered.Count}");
            foreach (var item in ReOrdered)
            {
                DataOut.changes.vane_bias_pwm.Add(item.VanePwmBias);
                DataOut.changes.vane_deg_to_pwm.Add(item.VaneDegToPwm);
                DataOut.changes.vane_max_pwm.Add(item.VanePwmMax);
                DataOut.changes.vane_min_pwm.Add(item.VanePwmMin);
                MaxDeflections.Add(item.VaneMaxDeflection);
            }
            DataOut.changes.max_deflection_deg.Add(MaxDeflections.Min());

            // save cals
            string target = "Completed_Calibrations";
            string path = Directory.GetCurrentDirectory();
            string cp = string.Format("{0}\\{1}\\VBAT{2}_{3}_Servo_Calibration_Data.json",
                                        path,
                                        target,
                                        txtTailNumber.Text,
                                        DateTime.Now.ToString("yyyyMMdd_hhmm")
                                        );

            if (!Directory.Exists(target))  // if it doesn't exist, create
                Directory.CreateDirectory(target);
            //todo need to save all cal data when pushing to params
            using (FileStream fs = File.Open(cp, FileMode.CreateNew))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(jw, DataOut);
                suscal();
            }
            MessageBox.Show($"Complete Calibration file successfully save to {cp}", "Calibration Completed Successfully!");
        }


        /********************************************************************************************************************/
        /********************************* end button handlers **************************************************************/
        /********************************************************************************************************************/

        // validate servo data
        public bool ValidateServo()
        {
            ClearChart();
            foreach (ServoData item in Servos)
            {
                // if this is our servo, continue the validation
                if (item.ServoNumber == CurrentServo)
                {
                    // check validation flag
                    if (item.isValidated)
                    {
                        MessageBox.Show("This tab is already Validated.  Click the UNLOCK button to make changes");
                        return true;
                    }
                    Debug.WriteLine(item.Name);
                    if (item.ServoType == "V")
                    {
                        if (!CheckServoData(PwmM)) return false;
                        PrepareVane(PwmM, item);
                    }
                    else
                    {
                        if (!CheckServoData(PwmMA)) return false;
                        PrepareAileron(PwmMA, item);
                    }
                    // must be valid if it made it this far
                    item.isValidated = true;
                    // update fileds and colors to show validation
                    Button ServoButton = (Button)this.GetControlByName(this, item.ServoBtnName);
                    ServoButton.BackColor = Color.Green;
                    ServoButton.ForeColor = Color.White;
                    DisableServoFields();
                    FieldColorValidated();
                    return true;
                }
            }
            return false;
        }

        // a convenient way to update a control by its string name
        public Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            //TextBox myTextBox = (TextBox)this.GetControlByName(this, "txtS3P50"); // called in main
            //myTextBox.Text = "Hello!"; // called in main

            if (ParentCntl.Name == NameToSearch)
                return ParentCntl;

            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                Control ResultCntl = GetControlByName(ChildCntl, NameToSearch);
                if (ResultCntl != null)
                    return ResultCntl;
            }
            return null;

        }

        public void DisableServoFields()
        {
            for (int i = 0; i < PwmM.Count; i++)
            {
                PwmM[i].Enabled = false;
            }
        }

        public void ChangeSevoButtonColorRed()
        {
            for (int i = 0; i < ServoButtons.Count; i++)
            {
                ServoButtons[i].BackColor = Color.Crimson;
                ServoButtons[i].ForeColor = Color.White;
            }
        }
        public void ChangeSevoButtonColorYellow()
        {
            for (int i = 0; i < ServoButtons.Count; i++)
            {
                ServoButtons[i].BackColor = Color.Yellow;
                ServoButtons[i].ForeColor = Color.Black;
            }
        }
        public void ChangeSevoButtonColorGreen()
        {
            for (int i = 0; i < ServoButtons.Count; i++)
            {
                ServoButtons[i].BackColor = Color.Green;
                ServoButtons[i].ForeColor = Color.White;
            }
        }
        public void ResetFieldColor()
        {
            for (int i = 0; i < PwmM.Count; i++)
            {
                PwmM[i].BackColor = Color.Yellow;
            }
        }

        public void FieldColorValidated()
        {
            for (int i = 0; i < PwmM.Count; i++)
            {
                PwmM[i].BackColor = Color.Yellow;
            }
        }

        public void EnableServoFields()
        {
            for (int i = 0; i < PwmM.Count; i++)
            {
                PwmM[i].Enabled = true;
            }
        }

        public void ClearTable()
        {
            for (int i = 0; i < PwmM.Count; i++)
            {
                PwmM[i].Clear();
                PwmM[i].BackColor = Color.Yellow;
            }
        }

        public void ClearChart()
        {
            chart1.Series["PWM"].Points.Clear();
            chart1.Series["Best Fit"].Points.Clear();
        }

        public void ClearPage()
        {
            ClearTable();
            ClearChart();
        }

        // prep data for display and saving
        public void PrepareAileron(List<TextBox> txtPwmMeasured,
                            ServoData Servo)
        {
            // define chart area
            chart = chart1.ChartAreas[0];

            for (int i = 0; i < txtPwmMeasured.Count; i++)
            {
                // convert strings from input to type double 
                double.TryParse(txtPwmMeasured[i].Text, out double d);
                Servo.VanePwmRealList[i] = d;
            }
            // graph the data
            VisualizeTypeA(Servo.VanePwmRealList, chart, chart1, "PWM", "Best Fit");
            // set data fields
            Servo.VanePwmMin = Servo.VanePwmRealList[0];

            Servo.VanePwmBias = Servo.VanePwmRealList[1];

            Servo.VanePwmMax = Servo.VanePwmRealList.Last();

            Servo.VaneDegToPwm = PwmToDegrees(txtPwmMeasured, 50);

            // find conservative max deflection ( taken from matlab script)
            double top = (Servo.VanePwmMax - Servo.VanePwmBias) / Servo.VaneDegToPwm;
            double bot = (Servo.VanePwmBias - Servo.VanePwmMin) / Servo.VaneDegToPwm;
            Debug.WriteLine($"TOP {top} bot {bot}");
            if (top < bot)
            {
                Servo.VaneMaxDeflection = TruncateFunction(top, 2);
            }
            else
            {
                Servo.VaneMaxDeflection = TruncateFunction(bot, 2);
            }
            Servo.VaneComplete = true;
        }

        
        public void PrepareVane(List<TextBox> txtPwmMeasured,
                                ServoData Servo)
        {
            chart = chart1.ChartAreas[0];

            for (int i = 0; i < txtPwmMeasured.Count(); i++)
            {
                double.TryParse(txtPwmMeasured[i].Text, out double d);
                Servo.VanePwmRealList[i] = d;
            }
            VisualizeTypeV(Servo.VanePwmRealList, chart, chart1, "PWM", "Best Fit");
            Servo.VanePwmMin = Servo.VanePwmRealList[0];

            Servo.VanePwmBias = Servo.VanePwmRealList[1];

            Servo.VanePwmMax = Servo.VanePwmRealList.Last();

            Servo.VaneDegToPwm = TruncateFunction(PwmToDegrees(txtPwmMeasured, 60), 2);

            double top = (Servo.VanePwmMax - Servo.VanePwmBias) / Servo.VaneDegToPwm;
            double bot = (Servo.VanePwmBias - Servo.VanePwmMin) / Servo.VaneDegToPwm;
            if (top < bot)
            {

                Servo.VaneMaxDeflection = TruncateFunction(top, 2);
            }
            else
            {
                Servo.VaneMaxDeflection = TruncateFunction(bot, 2);
            }
            Debug.WriteLine($"TOP {top} bot {bot}");
            Servo.VaneComplete = true;
        }

        // chop double down to 2 deimals places of precision
        public static double TruncateFunction(double number, int digits)
        {
            double stepper = (double)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (double)temp / stepper;
        }

        // under the hood of the graphing
        public static void VisualizeTypeA(List<double> PwmR,
                                    ChartArea chartArea,
                                    Chart chart,
                                    string series1,
                                    string series2)
        {
            // chart info
            chart.Series["Best Fit"].Color = Color.Orange;
            chart.Series["PWM"].Color = Color.Blue;
            chartArea.AxisX.Minimum = -40;
            chartArea.AxisX.Maximum = 40;
            chartArea.AxisY.Minimum = 1000;
            chartArea.AxisY.Maximum = 2000;
            var xValues = new double[] { -30, 0, 30 };
            for (int i = 0; i < xValues.Length; i++)
            {
                // points
                chart.Series[series1].Points.AddXY(xValues[i], PwmR[i]);
                // line
                chart.Series[series2].Points.AddXY(xValues[i], PwmR[i]);

            }
            Debug.WriteLine("Graphing Aileron Success");
        }

        public static void VisualizeTypeV(List<double> PwmR,
                                    ChartArea chartArea,
                                    Chart chart,
                                    string series1,
                                    string series2)
        {
            chart.Series["Best Fit"].Color = Color.Orange;
            chart.Series["PWM"].Color = Color.Blue;
            chartArea.AxisX.Minimum = -40;
            chartArea.AxisX.Maximum = 40;
            chartArea.AxisY.Minimum = 1000;
            chartArea.AxisY.Maximum = 2000;
            var xValues = new double[] { -30, 0, 30 };

            for (int i = 0; i < xValues.Length; i++)
            {
                // points
                chart.Series[series1].Points.AddXY(xValues[i], PwmR[i]);
                // line
                chart.Series[series2].Points.AddXY(xValues[i], PwmR[i]);

            }
            Debug.WriteLine("Graphing Vane Success");
        }

        // calculates pwm/degree
        private static double PwmToDegrees(List<TextBox> source, int divisor)
        {
            List<double> lst = new List<double>();
            for (int i = 0; i < source.Count; i++)
            {
                double.TryParse(source[i].Text, out double dd);
                lst.Add(dd);
            }

            double pwm2a = (lst.Last() - lst.First()) / divisor;
            return pwm2a;
        }

        // validate servo data
        public static bool CheckServoData(List<TextBox> txtPwmMeasured)
        {
            foreach (var item in txtPwmMeasured)
            {
                if (item.TextLength < 2 || item.TextLength > 4)
                {
                    // checks for proper length
                    item.BackColor = Color.IndianRed;
                    MessageBox.Show("Invalid PWM value in the table, Please correct it.");
                    item.BackColor = Color.Yellow;
                    return false;
                }
                if (double.TryParse(item.Text, out double ServoCmd))
                {
                    if (ServoCmd < 900 || ServoCmd > 2100)
                    {
                        item.BackColor = Color.IndianRed;
                        MessageBox.Show("Servo Value outside of usable range, Please fix it.");
                        item.BackColor = Color.Yellow;
                        return false;
                    }
                }
                else
                {
                    // checks for only numbers
                    item.BackColor = Color.IndianRed;
                    MessageBox.Show("Non numeric value in the table, Please fix it");
                    item.BackColor = Color.Yellow;
                    return false;
                }

                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    // checks for blank space
                    item.BackColor = Color.IndianRed;
                    MessageBox.Show("Non numeric value in the table, Please fix it");
                    item.BackColor = Color.Yellow;
                    return false;
                }
            }
            return true;
        }

        // extensive validation for param gen
        public bool ReadyForGen(TextBox PID, TextBox SN, List<ServoData> servos, bool gen = false)
        {
            bool pidOK = false;
            bool snOK = false;
            bool servoOK = false;
            if (PID.TextLength <= 3)
            {
                PID.BackColor = Color.IndianRed;
                MessageBox.Show("PID length incorrect");
                return false;
            }

            if (!Int32.TryParse(PID.Text, out _))
            {
                PID.BackColor = Color.IndianRed;
                MessageBox.Show("PID Numeric value incorrect");
                return false;
            }
            else
            {
                pidOK = true;
                PID.BackColor = Color.White;
            }

            if (SN.TextLength <= 2)
            {

                SN.BackColor = Color.IndianRed;
                MessageBox.Show("Error with Aircraft Serial Number");
                return false;
            }

            if (!Int32.TryParse(SN.Text, out _))
            {
                SN.BackColor = Color.IndianRed;
                MessageBox.Show("Aircraft Serial Number Numeric value incorrect");
                return false;
            }
            else
            {
                snOK = true;
                SN.BackColor = Color.White;
            }

            if (gen)
            {
                if (servos.Count < 10)
                {
                    MessageBox.Show("Not all servo data is complete");
                    return false;
                }
                foreach (var item in servos)
                {
                    try
                    {
                        if (!item.VaneComplete)
                        {
                            MessageBox.Show($"Not all servo data is complete. error: {item.Name}");
                            return false;
                        }
                        else
                        {
                            servoOK = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Not all servo data is complete.");
                        Debug.WriteLine($"One or more servo object(s) are null :{ex}");
                        return false;
                    }
                }
                if (snOK && pidOK && servoOK)
                {
                    btnGenerateParams.BackColor = Color.LightGreen;
                    btnGenerateParams.Text = "Generate Params";
                    return true;
                }
            }
            else
            {
                if (snOK && pidOK)
                {
                    return true;
                }
            }
            return false;
        }

        public void DisableParamButton()
        {
            btnGenerateParams.Enabled = false;
            btnGenerateParams.BackColor = SystemColors.Control;
        }

        public void EnableParamButton()
        {
            btnGenerateParams.Enabled = true;
            btnGenerateParams.BackColor = Color.LightGreen;
        }

        public void IsValidated(string btnName)
        {
            Button ServoButton = (Button)this.GetControlByName(this, btnName);
            ServoButton.BackColor = Color.Green;
            ServoButton.ForeColor = Color.White;
            FieldColorValidated();
            DisableServoFields();
        }

        public void UnlockTab(ServoData Servo, Button btn)
        {
            foreach (var item in Servos)
            {
                if (item.Name == Servo.Name)
                {
                    if (item.isValidated)
                    {
                        item.isValidated = false;
                        btn.BackColor = Color.Yellow;
                        btn.ForeColor = Color.Black;
                        ResetFieldColor();
                        EnableServoFields();
                        MessageBox.Show($"Servo Tab {CurrentServo} is now unlocked.  It must be revalidated to complete the calibration");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Servo Tab {CurrentServo} is already unlocked");
                    }
                }
            }
        }
    }
}
