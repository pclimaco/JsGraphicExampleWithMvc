using System.Collections.Generic;

namespace JsGraphicExampleWithMvc.ViewModels
{
    public class GraphicsViewModel
    {
        public Dictionary<string, List<ItemProperty>> ItemPropertyDictionary {get; set;}
    }
    public class ItemProperty{
        public string Category{ get; set;}
        public string Type{ get; set;}
        public string Value{ get; set;}
    }
}