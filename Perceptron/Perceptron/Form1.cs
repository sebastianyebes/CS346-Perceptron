using System;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        private int[][] train_data;
        private int[] targets;
        private double[] weights;


        private double bias;
        private double threshold;
        private double learningRate;
        private int NumOfEpoch;
        int x1;
        int x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            train_data = new int[4][];
            train_data[0] = new int[] { 0, 0 };
            train_data[1] = new int[] { 0, 1 };
            train_data[2] = new int[] { 1, 0 };
            train_data[3] = new int[] { 1, 1 };

            weights = new double[2];
            bias = 0;
            threshold = 0;
            TrainButton.Enabled = false;
            PredictButton.Enabled = false;
        }   

        private int Prediction(int[] inputs)
        {
            double weighted_sum = 0;

            // Calculate weighted sum
            for (int i = 0; i < inputs.Length; i++) { 
            
                weighted_sum += inputs[i] * weights[i];
            }

            weighted_sum += bias;
            
            // Checks if the sum is greater or lesser than the threshold
            if(weighted_sum >= threshold) {

                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void Train(int[][] inputs, int[] targets, double learningRate,int NumofEpoch)
        {
            Random rnd = new Random(new Random().Next());
            for (int i = 0; i < weights.Length; i++)
            {
                while (weights[i] != 0)
                {
                    weights[i] = rnd.Next(-1, 1);
                }
            }  

            for (int i = 0; i < NumOfEpoch; i++)
            {
                for (int j = 0; j < inputs.Length; j++)
                {
                    double output = Prediction(inputs[j]);
                    double error = targets[j] - output;

                    for(int x = 0; x < weights.Length; x++)
                    {
                        weights[x] += error * learningRate * inputs[j][x];
                    }

                    bias += learningRate * error;
                }
            }

            PredictButton.Enabled = true;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            learningRate = Double.Parse(LRateText.Text);
            NumOfEpoch = Int32.Parse(NumEpochText.Text);

            Train(train_data, targets, learningRate, NumOfEpoch);
        }

        private void PredictButton_Click(object sender, EventArgs e)
        {  
            int answer = Prediction(ChooseInput());

            OutputText.Text = "Output: " + answer.ToString();
        }

        private int[] ChooseInput()
        {
            if (x10radio.Checked)
            {
                x1 = 0;
            }
            else if (x11radio.Checked)
            {
                x1 = 1;
            }

            if (x21radio.Checked)
            {
                x2 = 1;
            }
            else if (x20radio.Checked)
            {
                x2 = 0;
            }

            return new int[] { x1, x2 };
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 0, 0, 0, 1 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 0, 1, 1, 1 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 0, 1, 1, 0 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 1, 1, 1, 0 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
        }
    }
}
