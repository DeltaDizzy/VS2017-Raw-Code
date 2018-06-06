using UnityEngine;

namespace ConfigParser
{
    class Parser : MonoBehaviour
    {
        ConfigNode node = new ConfigNode();
        //Get node from object
        void Parse(ConfigNode node)
        {
            node.GetNode("HYPERDRIVE");
        }
        
        
    }
}
