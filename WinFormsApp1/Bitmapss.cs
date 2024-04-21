namespace WinFormsApp1
{
    public partial class Bitmapss : Form
    {
        private Repository rs;
        public Bitmapss()
        {
            InitializeComponent();
            rs = new Repository(picOriginal, picGray);


        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Imagenes (*.jpg, *.png)|*.jpg;*.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] imageFiles = openFileDialog.FileNames;

                rs.ProcessImages(imageFiles);

            }

        }







    }
}