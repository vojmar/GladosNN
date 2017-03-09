using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladosBrain
{
    class Neuron
    {
        Dictionary<Neuron, uint> synapses;
        public Neuron(Neuron[] inputN)
        {
            synapses = new Dictionary<Neuron, uint>();
            foreach (var neuron in inputN)
            {
                synapses.Add(neuron,uint.MaxValue/2);
            }
        }
    }
}
