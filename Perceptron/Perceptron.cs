using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        float[] weights;
        public float learningRate;
        static public Random r = new Random();

        public Perceptron(int n, float rate)
        {
            this.learningRate = rate;

            this.weights = new float[n];
            // Start with random weights
            for(int i=0; i<n; i++)
            {
               this.weights[i] = (float)r.NextDouble() * 2 - 1; // range <-1:1>
            }

        }

        public void Train(float[] inputs, int desired)
        {
            int guess = this.Guess(inputs);
            float error = desired - guess;

            for(int i=0; i<weights.Length; i++)
            {
                weights[i] += inputs[i] * this.learningRate * error;
            }
        }

        public int Guess(float[] inputs)
        {
            float sum = 0;
            for(int i = 0; i<weights.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            return this.Activate(sum);
        }

        private int Activate(float sum)
        {
            if(sum>0)
                return 1;
            else
                return -1;
        }

        public float[] GetWeights()
        {
            return this.weights;
        }
    }
}
