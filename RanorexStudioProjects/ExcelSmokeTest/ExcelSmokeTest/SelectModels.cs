﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ExcelSmokeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectModels recording.
    /// </summary>
    [TestModule("fc571c8e-8dbe-4090-8fd6-8f0a74552278", ModuleType.Recording, 1)]
    public partial class SelectModels : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ExcelSmokeTestRepository repository.
        /// </summary>
        public static ExcelSmokeTestRepository repo = ExcelSmokeTestRepository.Instance;

        static SelectModels instance = new SelectModels();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectModels()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectModels Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE", "", "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Excel.CompteDeResultat' at 83;9.", repo.Excel.CompteDeResultatInfo, new RecordItemIndex(1));
            repo.Excel.CompteDeResultat.Click("83;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Excel.CompteDeResultat1' at 70;10.", repo.Excel.CompteDeResultat1Info, new RecordItemIndex(2));
            repo.Excel.CompteDeResultat1.Click("70;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Excel.Next' at 42;14.", repo.Excel.NextInfo, new RecordItemIndex(3));
            repo.Excel.Next.Click("42;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
