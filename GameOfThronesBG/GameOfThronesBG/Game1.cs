#region Using Statements
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using GameOfThronesBG.Game_Piece_Classes;
using GameOfThronesBG.LogicClasses;
#endregion

namespace GameOfThronesBG
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        //graphics stuff
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Viewport vp;

        //containers for things
        ArrayList territories;
        ArrayList players;

        //important variables
        int numPlayers;
        string gamestate;
        int currentTurn;

        

        //stuff that i don't even know if i need
        int screenWidth;
        int screenHeight;

        //graphics variables
        Texture2D baseBoardImage;
        Rectangle town;

        public Game1()
            : base()
        {
            //set up the graphics device / viewable area
            graphics = new GraphicsDeviceManager(this);                    
            screenWidth = 1980;
            screenHeight = 2975;
            vp = new Viewport(0, 0, 1980, 2975);

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //get variables set up.  not much here until we get the numPlayers
            gamestate = "New Game";
                          
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            

            // TODO: use this.Content to load your game content here
            //load resources
            baseBoardImage = Content.Load<Texture2D> ("GoTBoard");

            //set some graphics settings
            Window.AllowUserResizing = true;
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (gamestate == "New Game")
            {
                //opens dialog to select number of players
                numPlayers = PlayerSetup.DoPlayerSetup();
                if (numPlayers != 0)
                {
                    //fills the map container and changes some values based on number players
                    string territoryPath;
                    territoryPath = @"C:\Users\Jobber Dobbs\documents\visual studio 2010\Projects\GameOfThronesBG\GameOfThronesBG\Content\territories.txt";
                    territories = MapPopulator.CreateTerritoryList(territoryPath, numPlayers);
                    gamestate = "Set Up Players";
                }
            }
            if(gamestate == "Set Up Players")
            {
                //fills player container and puts initial settings in
                players = PlayerSetup.CreatePlayers(numPlayers);
                gamestate = "Movement";
            }


            //some stuff to scroll around the map with arrow keys
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                if (vp.Y > -2975 + graphics.GraphicsDevice.DisplayMode.Height)
                {
                    vp.Y -= 10;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (vp.Y < 0)
                {
                    vp.Y += 10;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                if (vp.X < 0)
                {
                    vp.X += 10;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                if (vp.X > -1980 + graphics.GraphicsDevice.DisplayMode.Width)
                {
                    vp.X -= 10;
                }
            }
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = 1980;
            graphics.PreferredBackBufferHeight = 2975;
            GraphicsDevice.Viewport = vp;
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            

            spriteBatch.Begin();
            DrawBackground();
            DrawOwners();
            DrawUnits();
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);

        }

        //draws the base board
        private void DrawBackground()
        {

            Rectangle screenRectangle = new Rectangle(0, 0, screenWidth, screenHeight);
            spriteBatch.Draw(baseBoardImage, screenRectangle, Color.White);
        }

        //draws the territory rectangles
        private void DrawOwners()
        {
            int tempx = 0;
            int tempy = 0;
            int tempOwner = 0;
            foreach (Territory terr in territories)
            {
                tempx = terr.PosX;
                tempy = terr.PosY;
                tempOwner = terr.Owner;
                Color ownerColor = ColorMaker.ColorChooser(tempOwner);
                town = new Rectangle(tempx, tempy, 105, 30);
                Texture2D texture = new Texture2D(graphics.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);

                

                texture.SetData<Color>(new Color[] { ownerColor });
                spriteBatch.Draw(texture, town, ownerColor);
            }
        }

        //draws the units near the territory rectangles (hopefully)
        private void DrawUnits()
        {
        }
               
    }
}
