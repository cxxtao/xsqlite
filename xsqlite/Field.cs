﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xsqlite {
    public class Field {
        public string type {
            get;
            set;
        }
        public string name {
            get;
            set;
        }
        public bool primary {
            get;
            set;
        }
        public List<string> search_keys {
            get;
            set;
        }
        public List<string> search_values {
            get;
            set;
        }
        public List<string> remove_labels {
            get;
            set;
        }
        public List<string> update_keys {
            get;
            set;
        }
        public List<string> update_values {
            get;
            set;
        }
    }
}
