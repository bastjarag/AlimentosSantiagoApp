﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlimentosSantiagoDesktop.Formularios
{
    public partial class ProveedorManager : Form
    {
        public delegate void OnClose();
        public OnClose onClose;

        public ProveedorManager()
        {
            InitializeComponent();
        }
    }
}
