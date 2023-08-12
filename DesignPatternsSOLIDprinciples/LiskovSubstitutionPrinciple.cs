using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSOLIDprinciples
{
    /// <summary>
    ///  Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
    /// LSP states that the child class should be perfectly substitutable for their parent class. 
    /// If class C is derived from P then C should be substitutable for P.
    /// 
    /// LSP is a fundamental principle of SOLID Principles and states that if program 
    /// or module is using base class then derived class should be able to extend 
    /// their base class without changing their original implementation.
    /// </summary>


    //there are another way to check if the code doesn`t meet the LSP, if child inhert not used parent features like:
    //if we have subscibers types in Movie system, and parent class has two methods giveLimittedAccess and giveUnlimittedAccess
    //standard Subsciber will inherit the giveUnlimittedAccess which is restriction on standard Subsciber so here is the issue the standard Subsciber must not inherit the giveUnlimittedAccess
    //to solve this give the parent just the common function if there are private business add it inside the child
    //link of the above example https://medium.com/@alexandre.malavasi/liskov-substitution-principle-in-c-1f4bdff2b92f

    //the issue here is that we replace the circle[child] with Triangle [parent] where they are two different shapes an can`t be the same
    public class Triangle
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
    //correct implementation add interface with get shape to be used by derived classes where the above child[Circl] is
    //changed the implementation of the parent[Triangle]
    //now the parent class shape is general and can referenced or replaced by any of its childs
    //like Shape shape=new RightTriangle(); shape.GetShape(); now can put the shape of triagle in it parent object

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class RightTriangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class RightCircle : RightTriangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
