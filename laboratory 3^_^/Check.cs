﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_3 {
    class Check {
        public bool CheckInterval(double left, double right) {
            if (left >= right) {
                return false;
            }
            return true;
        }

        public bool CheckStep(double a) {
            if (a <= 0 || a >= 100) {
                return false;
            }
            return true;
        }

        public bool CheckCoefficient(double a) {
            if (a <= -100 || a >= 100) {
                return false;
            }
            return true;
        }
    }
}
