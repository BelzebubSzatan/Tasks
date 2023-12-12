using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Model {
    public class TaskModel {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Importance { get; set; }
        public string Image {
            get {
                if (Importance == "Ważne")
                    return "https://upload.wikimedia.org/wikipedia/commons/6/62/Nuvola_apps_important.png";
                if (Importance == "Bardzo Ważne")
                    return "https://static.vecteezy.com/system/resources/previews/021/433/032/non_2x/important-rubber-stamp-free-png.png";
                return "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Info_icon_001.svg/2048px-Info_icon_001.svg.png";
            }
        }
    }
}
