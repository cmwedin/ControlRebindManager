using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.ControlRebindManager
{
    [CreateAssetMenu(fileName = "InputType", menuName = "Packages/ControlRebindManager/InputType", order = 0)]
    public class InputTypeSO : ScriptableObject {
        /// <summary>
        /// The name that will be displayed for the input
        /// </summary>
        [SerializeField] private string displayName;
        public string DisplayName { get => displayName; }
        /// <summary>
        /// The default key for the input
        /// </summary>
        [SerializeField] private KeyCode defaultKey;
        public KeyCode DefaultKey { get => defaultKey; }
        /// <summary>
        /// The default alternate key for the input
        /// </summary>
        [SerializeField] private KeyCode alternateDefaultKey;
        public KeyCode AlternateDefaultKey { get => alternateDefaultKey; }
        [SerializeField] private KeyCode currentKey;
        public KeyCode CurrentKey { get => currentKey; }
    }
}