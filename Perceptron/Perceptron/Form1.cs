using System;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        private int[][] train_data;
        private int[] targets;
        private double[] weights;

        private int errors;
        private int limit;
        private double bias;
        private double learningRate;
        private int NumOfEpoch;
        private int x1;
        private int x2;

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

            limit = 100;
            bias = 0;
            TrainButton.Enabled = false;
            PredictButton.Enabled = false;
        }   

        /// <summary>
        /// Resets the values
        /// </summary>
        private void Reset()
        {
            Epochlabel.Text = "Epoch: ";
            OutputText.Text = "Output: ";

            errors = 0;
            bias = 0;
            NumOfEpoch = 0;
        }

        /// <summary>
        /// Algorithm that calculates the sum of weights then check if it returns 1 or 0
        /// </summary>
        /// <param name="inputs"> Inputs to be predicted </param>
        /// <returns> 1 or 0 depends on the threshold </returns>
        private int Prediction(int[] inputs)
        {
            double weighted_sum = 0;

            // Calculate weighted sum
            for (int i = 0; i < inputs.Length; i++) { 
            
                weighted_sum += inputs[i] * weights[i];
            }

            weighted_sum += bias;
            
            // Checks if the sum is greater or lesser than the threshold (0)
            if(weighted_sum >= 0) {

                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Algorithm that lets you train the program using the inputs and targets
        /// </summary>
        /// <param name="inputs"> training data </param>
        /// <param name="targets"> target output </param>
        /// <param name="learningRate"> Controls the stepsize of the weight update </param>
        private void Train(int[][] inputs, int[] targets, double learningRate)
        {
            // Reset all values before training
            Reset();

            // Initialize weights
            Random rnd = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                do
                {
                    weights[i] = rnd.Next(-1, 1);
                } while (weights[i] == 0);
            }  

            // Calculates the output using the input and learning rate
            for (int i = 0; i < limit; i++)
            {
                errors = 0;

                for (int j = 0; j < inputs.Length; j++)
                {
                    double output = Prediction(inputs[j]);
                    double error = targets[j] - output;

                    for(int x = 0; x < weights.Length; x++)
                    {
                        weights[x] += error * learningRate * inputs[j][x];
                    }

                    if (output != targets[j])
                    {
                        errors++;
                    }

                    bias += learningRate * error;
                }

                NumOfEpoch++;

                // If errors = 0, loop will stop
                if(errors == 0)
                {
                    break;
                }
            }

            PredictButton.Enabled = true;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            learningRate = Double.Parse(LRateText.Text);

            Train(train_data, targets, learningRate);

            Epochlabel.Text = "Epoch: " + NumOfEpoch.ToString();
        }

        private void PredictButton_Click(object sender, EventArgs e)
        {  
            OutputText.Text = "Output: " + Prediction(ChooseInput()).ToString();
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
            Reset();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 0, 1, 1, 1 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
            Reset();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 0, 1, 1, 0 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
            Reset();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            targets = new int[] { 1, 1, 1, 0 };
            TrainButton.Enabled = true;
            PredictButton.Enabled = false;
            Reset();
        }
    }
}
