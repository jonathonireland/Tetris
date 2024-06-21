namespace Tetris
{
    public class SBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] { 
                new(0,1), 
                new(0,2), 
                new(1,0), 
                new(1,1) 
            }, // State 0 done

            new Position[] { 
                new(0,1), 
                new(1,1), 
                new(1,2), 
                new(2,2) 
            }, // State 1 done
            
            new Position[] { 
                new(1,1), 
                new(1,2), 
                new(2,0), 
                new(2,1) 
            }, // State 2 done
            
            new Position[] { 
                new(0,0), 
                new(1,0), 
                new(1,1), 
                new(2,1) 
            }, // State 3 done 
        };

        public override int Id => 5;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}
