using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// <copyright file="Form1.cs + ServoData.cs" company="Martin UAV">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
// <author>Ryan Pullen</author>
// <date>04/13/2020 16:21:00 PM </date>
// <summary>Servo Calibration Tool</summary>

namespace SurfaceCal
{
    public class ServoData
    {
        public string Name { get; set; }
        public double VaneMaxDeflection { get; set; }
        public double VaneSlope { get; set; }
        public double VanePwmMin { get; set; }
        public double VanePwmBias { get; set; }
        public double VanePwmMax { get; set; }
        public double VaneDegToPwm { get; set; }
        public bool VaneComplete { get; set; }
        public List<double> VanePwmRealList { get; set; }
        public List<double> VanePwmCalcList { get; set; }
        public int TabStatus { get; set; }
        public int Position { get; set; }
        public int ServoNumber { get; set; }
        public string ServoBtnName { get; set; }
        public string ServoType { get; set; }
        public bool isValidated { get; set; }

        public ServoData()
        {
            VaneMaxDeflection = 0;
            VanePwmMin = 0;
            VanePwmBias = 0;
            VanePwmMax = 0;
            VaneDegToPwm = 0;
            VaneComplete = false;
            VaneSlope = 0;
        }
    }
    // changes object for AP version 1.68
    public class Changes
    {
        public List<double> flap_bias_pwm { get; set; }
        public List<double> flap_deg_to_pwm { get; set; }
        public List<double> flap_max_pwm { get; set; }
        public List<double> flap_min_pwm { get; set; }
        public List<double> vane_bias_pwm { get; set; }
        public List<double> vane_deg_to_pwm { get; set; }
        public List<double> vane_max_pwm { get; set; }
        public List<double> vane_min_pwm { get; set; }
        public List<double> max_deflection_deg { get; set; }
    }

    // root object for changes object -- needed to format json the way 1.68 wants it.
    public class RootObject
    {
        public Changes changes = new Changes();
    }

    // suspended cal object
    public class SuspendCal
    {
        public string PID { get; set; }
        public string SN { get; set; }
        public string Timestamp { get; set; }
        public List<ServoData> ServoList { get; set; }
    }

    // class for saving/loading cal data
    public static class CalData
    {
        public static void SaveCal(SuspendCal Cal, bool isSuspend = true)
        {
            string path = Directory.GetCurrentDirectory();
            string cp = string.Empty;

            if (isSuspend)
            {
                string target = "Suspended_Cal_Data";
                cp = $"{path}\\{target}\\VBAT{Cal.SN}_{Cal.Timestamp}_Suspended_Calibration.json";
                if (IsDir("f", cp))
                {
                    DialogResult dr = MessageBox.Show("This file already exists, click Yes to append _copy_ " +
                                                        "to the file name, or No to abort",
                                                        "Dupicate file Warning",
                                                        MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            cp += "_copy_";
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
            }
            else
            {
                string target = "Archived_Cal_Data";
                cp = $"{path}\\{target}\\VBAT{Cal.SN}_{Cal.Timestamp}_Archived_Calibration.json";
                if (IsDir("f", cp))
                {
                    DialogResult dr = MessageBox.Show("This file already exists, click Yes to append _copy_ " +
                                                        "to the file name, or No to abort",
                                                        "Dupicate file Warning",
                                                        MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            cp += "_copy_";
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
            }
            using (FileStream fs = File.Open(cp, FileMode.CreateNew))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(jw, Cal);
            }
            if (isSuspend)
            {
                MessageBox.Show($"Suspended Calibration file successfully saved to {cp}");
            }
            else
            {
                MessageBox.Show($"Archived Calibration file successfully saved to {cp}");
            }
        }


        public static SuspendCal LoadCal(OpenFileDialog file)
        {
            SuspendCal SuspendedData = new SuspendCal();
            string target = "Suspended_Cal_Data";
            file.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), target);
            file.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
                using (StreamReader F = File.OpenText(file.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    SuspendedData = (SuspendCal)serializer.Deserialize(F, typeof(SuspendCal));
                }
            return SuspendedData;
        }


        public static Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
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

        public static bool IsDir(string type, string fp)
        {
            if (type.ToLower() == "d")
            {
                return Directory.Exists(fp);
            }
            else
            {
                return File.Exists(fp);
            }
        }
    }
}
