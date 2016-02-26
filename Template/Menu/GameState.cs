using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template {
    abstract class GameState {


        abstract public void update();

        abstract public void draw();


    }
}
