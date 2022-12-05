using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day5.Models
{
    internal class Containers
    {

        private List<Stack<Crate>> _stacks;
        public List<Stack<Crate>> Stacks { get { return _stacks; } }

        public Containers()
        {
            _stacks = InitialiseStackCollection();
        }

        public void Move(Command c)
        {
            for(int moveCount = 0; moveCount < c.NumberToMove; moveCount++)
            {
                // remove from column
                var crateToRemove = _stacks[c.FromColumn - 1].Pop();

                // push on to column
                _stacks[c.ToColumn - 1].Push(crateToRemove);
            }            
        }

        public void NewMove(Command c)
        {
            if (c.NumberToMove == 1)
            {
                // push single crate on to target column
                _stacks[c.ToColumn - 1].Push(_stacks[c.FromColumn - 1].Pop());
            }
            else if(c.NumberToMove > 1)
            {
                List<Crate> cratesToMove = new List<Crate>();

                // Pop each crate from the source column
                for (int moveCount = 0; moveCount < c.NumberToMove; moveCount++)
                {
                    cratesToMove.Add(_stacks[c.FromColumn - 1].Pop());
                }

                // Push each crate on to the target column
                for(int index = cratesToMove.Count-1; index >= 0; index--)
                {
                    _stacks[c.ToColumn - 1].Push(cratesToMove[index]);
                }
            }
        }
        private List<Stack<Crate>> InitialiseStackCollection2()
        {
            /*
                    [D]    
                [N] [C]    
                [Z] [M] [P]
                 1   2   3 
             */
            List<Stack<Crate>> stackCollection = new List<Stack<Crate>>();

            // initialise stack
            Stack<Crate> s = new Stack<Crate>();
            s.Push(new Crate("Z"));
            s.Push(new Crate("N"));
            stackCollection.Add(s);

            s = new Stack<Crate>();
            s.Push(new Crate("M"));
            s.Push(new Crate("C"));
            s.Push(new Crate("D"));
            stackCollection.Add(s);

            s = new Stack<Crate>();
            s.Push(new Crate("P"));
            stackCollection.Add(s);

            return stackCollection;
        }

        private List<Stack<Crate>> InitialiseStackCollection()
        {
            /*
                [G] [R]                 [P]    
                [H] [W]     [T] [P]     [H]    
                [F] [T] [P] [B] [D]     [N]    
            [L] [T] [M] [Q] [L] [C]     [Z]    
            [C] [C] [N] [V] [S] [H]     [V] [G]
            [G] [L] [F] [D] [M] [V] [T] [J] [H]
            [M] [D] [J] [F] [F] [N] [C] [S] [F]
            [Q] [R] [V] [J] [N] [R] [H] [G] [Z]
             1   2   3   4   5   6   7   8   9 

             */
            List<Stack<Crate>> stackCollection = new List<Stack<Crate>>();

            // initialise stack
            // 1 [L][C][G][M][Q]
            Stack<Crate> s = new Stack<Crate>();
            s.Push(new Crate("Q"));
            s.Push(new Crate("M"));
            s.Push(new Crate("G"));
            s.Push(new Crate("C"));
            s.Push(new Crate("l"));
            stackCollection.Add(s);


            // 2 [G][H][F][T][C][L][D][R]
            s = new Stack<Crate>();
            s.Push(new Crate("R"));
            s.Push(new Crate("D"));
            s.Push(new Crate("L"));
            s.Push(new Crate("C"));
            s.Push(new Crate("T"));
            s.Push(new Crate("F"));
            s.Push(new Crate("H"));
            s.Push(new Crate("G"));
            stackCollection.Add(s);

            // 3 [R][W][T][M][N][F][J][V]
            s = new Stack<Crate>();
            s.Push(new Crate("V"));
            s.Push(new Crate("J"));
            s.Push(new Crate("F"));
            s.Push(new Crate("N"));
            s.Push(new Crate("M"));
            s.Push(new Crate("T"));
            s.Push(new Crate("W"));
            s.Push(new Crate("R"));
            stackCollection.Add(s);


            // 4 [P][Q][V][D][F][J]
            s = new Stack<Crate>();
            s.Push(new Crate("J"));
            s.Push(new Crate("F"));
            s.Push(new Crate("D"));
            s.Push(new Crate("V"));
            s.Push(new Crate("Q"));
            s.Push(new Crate("P"));
            stackCollection.Add(s);

            // 5 [T][B][L][S][M][F][N]
            s = new Stack<Crate>();
            s.Push(new Crate("N"));
            s.Push(new Crate("F"));
            s.Push(new Crate("M"));
            s.Push(new Crate("S"));
            s.Push(new Crate("L"));
            s.Push(new Crate("B"));
            s.Push(new Crate("T"));
            stackCollection.Add(s);

            // 6 [P][D][C][H][V][N][R]
            s = new Stack<Crate>();
            s.Push(new Crate("R"));
            s.Push(new Crate("N"));
            s.Push(new Crate("V"));
            s.Push(new Crate("H"));
            s.Push(new Crate("C"));
            s.Push(new Crate("D"));
            s.Push(new Crate("P"));
            stackCollection.Add(s);

            // 7 [T][C][H]
            s = new Stack<Crate>();
            s.Push(new Crate("H"));
            s.Push(new Crate("C"));
            s.Push(new Crate("T"));
            stackCollection.Add(s);

            // 8 [P][H][N][Z][V][J][S][G]
            s = new Stack<Crate>();
            s.Push(new Crate("G"));
            s.Push(new Crate("S"));
            s.Push(new Crate("J"));
            s.Push(new Crate("V"));
            s.Push(new Crate("Z"));
            s.Push(new Crate("N"));
            s.Push(new Crate("H"));
            s.Push(new Crate("P"));
            stackCollection.Add(s);

            // 9 [G][H][F][Z]
            s = new Stack<Crate>();
            s.Push(new Crate("Z"));
            s.Push(new Crate("F"));
            s.Push(new Crate("H"));
            s.Push(new Crate("G"));
            stackCollection.Add(s);

            return stackCollection;
        }

    }
}
