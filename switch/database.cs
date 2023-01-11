using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace switch
    {
        class database
        {
            public string ConnectionString()
            {
                string connection = "datasource=localhost; user=root; password=; Database=switch";
                return connection;
            }
        }
    }