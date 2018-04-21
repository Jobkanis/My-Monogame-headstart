using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace Shoot
{
    class MainGameFactory
    {
        public Game1 baseGame;
        public DrawVisitor drawVisitor;
        public MainGame mainGame;


        public MainGameFactory(Game1 baseGame)
        {
            this.baseGame = baseGame;

        }

        // drawvisitor


        public ContentManager content;
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public void initializeDrawVisitor(GraphicsDeviceManager graphics, SpriteBatch spriteBatch, ContentManager content)
        {
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.content = content;

            this.drawVisitor = new DrawVisitor(graphics, spriteBatch, content, this);
        }


        public DrawVisitor getDrawVisitor()
        {
            return this.drawVisitor;
        }

        
        // maingame

        public void initialiseMainGame()
        {
            this.mainGame = new MainGame(this);
        }

        public MainGame getMainGame()
        {
            return this.mainGame;
        }

        // Object Facotory


        //MainCharacter
        public MainCharacter getMainCharacter(Position position) {
            return new MainCharacter(this, position);
        }

    }
}
