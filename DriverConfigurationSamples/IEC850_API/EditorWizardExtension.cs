﻿using System;
using Scada.AddIn.Contracts;
using DriverCommon;

namespace IEC850_API
{
    /// <summary>
    /// Description of Editor Wizard Extension.
    /// </summary>
    [AddInExtension("IEC850_API", "Test IEC850 API, Import and Export", "Drivers API/Export/Import")]
    public class EditorWizardExtension : IEditorWizardExtension
    {
        private Log _log;
        private DriverContext _driverContext;

        const string DriverIdent = "IEC850";
        const string DriverName = "IEC 61850 Treiber";
        const string XmlSuffixBefore = "before";
        const string XmlSuffixAfter = "after";

        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            _log = new Log(context, DriverIdent);

            try
            {
                _driverContext = new DriverContext(context, _log, DriverName, false);

                // enter your code which should be executed when starting the SCADA Editor Wizard

                _log.Message("begin test");

                _driverContext.Export(XmlSuffixBefore);

                if (_driverContext.OpenDriver(10))
                {
                    _driverContext.ModifyCommonProperties();
                    _driverContext.ModifyCOMProperties();

                    ModifyOptions();

                    _driverContext.CloseDriver();

                    _driverContext.Export(XmlSuffixAfter);
                    _driverContext.Import(XmlSuffixBefore);
                }

                _log.Message("end test");
            }
            catch (Exception ex)
            {
                _log.ExpectionMessage($"An exception has been thrown: {ex.Message}", ex);
                throw;
            }
        }

        private void ModifyOptions()
        {
            _log.FunctionEntryMessage("modify options");

            _driverContext.SetStringProperty("DrvConfig.Options.ConfigurationFileName", "d:\\temp\\ConfiguratuionFileName.txt", true);
            _driverContext.SetBooleanProperty("DrvConfig.Options.DeactivateDoublePointMapping");
            _driverContext.SetStringProperty("DrvConfig.Options.DirectoryForFileTransfer", "d:\\temp", true);
            _driverContext.IncreaseSignedProperty("DrvConfig.Options.IdentificationForExternalName", 0, 100000);
            _driverContext.SetBooleanProperty("DrvConfig.Options.DoNotPurgeBRCB");
            _driverContext.IncreaseSignedProperty("DrvConfig.Options.OriginatorCategory", 0, 100000);

            _log.FunctionExitMessage();
        }

        #endregion
    }

}
