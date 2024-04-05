namespace Week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_genClick_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
               
                listView1.Items.Clear();


                try
                {
                    
                    await Task.Run(() =>
                    {
                        for (int i = 0; i < n; i++)
                        {
                            
                            int fibonacciNumber = Fibonacci(i);
                            UpdateUI(fibonacciNumber);
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.");
            }
        }
        private void UpdateUI(int number)
        {
           
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new MethodInvoker(delegate { listView1.Items.Add(number.ToString()); }));
            }
            else
            {
                listView1.Items.Add(number.ToString());
            }
        }
        private int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
