using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Apartment.Gas.Service.RNApartmentGasService
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNApartmentGasServiceModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNApartmentGasServiceModule"/>.
        /// </summary>
        internal RNApartmentGasServiceModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNApartmentGasService";
            }
        }
    }
}
