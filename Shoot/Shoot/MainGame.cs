using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    class MainGame: Object
    {

        MainCharacter mainCharacter;

        public MainGame(MainGameFactory mainGameFactory)
            : base(mainGameFactory)
        {
            this.mainCharacter = this.mainGameFactory.getMainCharacter(new Position(50, 50));
        }

        public override void Draw()
        {
            this.drawVisitor.startDraw();

            //draw logic
            this.mainCharacter.Draw();

            this.drawVisitor.EndDraw();
        }

        public override void Update(float gameTime)
        {
            this.mainCharacter.Update(gameTime);
        }
    }
}
