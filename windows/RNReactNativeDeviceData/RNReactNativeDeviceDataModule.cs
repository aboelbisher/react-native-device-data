using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Device.Data.RNReactNativeDeviceData
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeDeviceDataModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeDeviceDataModule"/>.
        /// </summary>
        internal RNReactNativeDeviceDataModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeDeviceData";
            }
        }
    }
}
