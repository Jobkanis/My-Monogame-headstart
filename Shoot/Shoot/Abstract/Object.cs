using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    abstract class Object : Drawable, Updateable
    {
        public MainGameFactory mainGameFactory;
        public MainGame mainGame;
        public DrawVisitor drawVisitor;
        public Position position = new Position();
        public Size size = new Size();

        public Object(MainGameFactory mainGameFactory)
        {
            this.mainGameFactory = mainGameFactory;
            this.drawVisitor = mainGameFactory.getDrawVisitor();
            this.mainGame = mainGameFactory.getMainGame();
        }

        public Object(MainGameFactory mainGameFactory, Position position, Size size)
        {
            this.mainGameFactory = mainGameFactory;
            this.drawVisitor = mainGameFactory.getDrawVisitor();
            this.mainGame = mainGameFactory.getMainGame();
            this.size = size;
            this.position = position;
        }

        public abstract void Draw();
        public abstract void Update(float gameTime);
    }
}
