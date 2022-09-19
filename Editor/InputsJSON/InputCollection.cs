namespace SadSapphicGames.ControlRebindManager.Editor
{
    /// <summary>
    /// struct used to model the contents of an inputs json file
    /// </summary>
    [System.Serializable]
    public struct InputCollection {
        /// <summary>
        /// The entries of the input json 
        /// </summary>
        public InputType[] InputTypes;
    }
}