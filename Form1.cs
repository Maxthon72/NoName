namespace WF
{
    public partial class Form1 : Form
    {

        BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();

            Data a1 = new Data
            {
                Id = 1,
                Name = "Maciej",
                Surname = "Maciejewski",
                Sex = 'M',
                DateOfBirth = "2000-09-18"
            };

            Data a2 = new Data
            {
                Id = 2,
                Name = "Maciejs",
                Surname = "Maciejewsk",
                Sex = 'F',
                DateOfBirth = "2000-09-14"
            };
            dao.MyList.Add(a1);
            dao.MyList.Add(a2);

            //conect the list and view
            bindingSource.DataSource = dao.MyList;

            dataGridView1.DataSource = bindingSource; 

        }
    }
}