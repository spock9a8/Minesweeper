using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template {
    static class ResourceManager {

        static Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();

        static public void addTexture(Texture2D t, string k) {
            textures.Add(k, t);
        }
        
        static public Texture2D getTexture(string k) {
            try {
                return textures[k];
            } catch (KeyNotFoundException e) {
                Console.WriteLine("KEY '" + k + "' NOT FOUND");
            }
            return getTexture("missingTexture");  
        }
    }
}
