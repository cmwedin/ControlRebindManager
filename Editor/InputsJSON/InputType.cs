using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.ControlRebindManager.Editor
{
    /// <summary>
    /// struct used to model the entries of the input json file
    /// </summary>
    [System.Serializable]
    public struct InputType
    {
        /// <summary>
        /// The Entries display name
        /// </summary>
        public string DisplayName;
        /// <summary>
        /// The default key of the input
        /// </summary>
        public string DefaultKey;
        /// <summary>
        /// The current key of the input
        /// </summary>
        public string CurrentKey;
    }
}