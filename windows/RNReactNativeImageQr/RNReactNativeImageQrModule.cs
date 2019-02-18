using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Image.Qr.RNReactNativeImageQr
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeImageQrModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeImageQrModule"/>.
        /// </summary>
        internal RNReactNativeImageQrModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeImageQr";
            }
        }
    }
}
