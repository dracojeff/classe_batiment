using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseBatiment

{
    class Entrepot
    {
        private string _revetement;
        private string _quaidedechargement;

        public Entrepot(string revetement)
        {
            _revetement = revetement;
        }
        public void SetRevetement(string revetement)
        {
            _revetement = revetement;
        }
        public string GetRevetement()
        {
            return _revetement;
        }
        public override string ToString()
        {
            return base.ToString() + " revetement : " + _revetement;
        }
    }
}
