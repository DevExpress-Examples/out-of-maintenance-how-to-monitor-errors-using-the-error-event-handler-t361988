using DevExpress.XtraMap;
using System;
using System.Windows.Forms;

namespace MapErrorEvent {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            ImageLayer imageLayer = new ImageLayer();
            mapControl1.Layers.Add(imageLayer);
            WmsDataProvider provider = new WmsDataProvider();
            imageLayer.DataProvider = provider;
            provider.ServerUri = "http://YOUR_SERVER_URI";
            provider.ActiveLayerName = "ACTIVE_LAYER_NAME";
            imageLayer.Error += OnError;
        }
        private void OnError(object sender, MapErrorEventArgs e) {
            MessageBox.Show(e.Exception.Message);
        }
    }
}
