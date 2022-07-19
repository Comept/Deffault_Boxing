using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing.Models
{

    public class Output_JSON
    {
        public Cargospace cargoSpace { get; set; }
        public Cargo[] cargos { get; set; }
        public Unpacked[] unpacked { get; set; }
        public Output_JSON(float[] size, List<Package> fins, List<Package> unPackages)
        {
            cargoSpace = new Cargospace(size);
            cargos = new Cargo[fins.Count];
            for (int i = 0; i < fins.Count-1; i++)
            {
                cargos[i] = new Cargo(fins[i], i);
            }
            unpacked = new Unpacked[unPackages.Count];
            for (int i = 0; i < unPackages.Count - 1; i++)
            {
                unpacked[i] = new Unpacked(unPackages[i], i);
            }

        }
    }

    public class Cargospace
    {
        public Loading_Size loading_size = new Loading_Size();
        public float[] position = new float[3];
        public string type { get; set; }
        public Cargospace(float[] size)
        {
            loading_size = new Loading_Size();
            loading_size.height = size[2];
            loading_size.width = size[1];
            loading_size.length = size[0];
            position[0] = 0;
            position[1] = 0;
            position[2] = 0;
            type = "pallet";
        }
    }

    public class Loading_Size
    {
        public float height { get; set; }
        public float length { get; set; }
        public float width { get; set; }
    }

    public class Cargo
    {
        public Calculated_Size calculated_size = new Calculated_Size();
        public string cargo_id { get; set; }
        public int id { get; set; }
        public float mass { get; set; }
        public Position position = new Position();
        public Size size = new Size();
        public int sort { get; set; }
        public bool stacking { get; set; }
        public bool turnover { get; set; }
        public string type { get; set; }
        public Cargo(Package fin, int i)
        {
            calculated_size.height = fin.Size[2];
            calculated_size.width = fin.Size[1];
            calculated_size.length = fin.Size[0];
            cargo_id = fin.Group_id;
            id = i;
            mass = fin.Mass;
            position.x = fin.Position[0];
            position.y = fin.Position[2];
            position.z = fin.Position[1];
            size.height = fin.Size[2];
            size.width = fin.Size[1];
            size.length = fin.Size[0];
            sort = 1;
            stacking = true;
            turnover = true;
            type = "box";
        }
    }

    public class Calculated_Size
    {
        public float height { get; set; }
        public float length { get; set; }
        public float width { get; set; }
    }

    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Size
    {
        public float height { get; set; }
        public float length { get; set; }
        public float width { get; set; }
    }

    public class Unpacked
    {
        public string group_id { get; set; }
        public int id { get; set; }
        public float mass { get; set; }
        public Position position = new Position();
        public Size size = new Size();
        public int sort { get; set; }
        public bool stacking { get; set; }
        public bool turnover { get; set; }
        public Unpacked(Package fin, int i)
        {
            group_id = fin.Group_id;
            id = i;
            mass = fin.Mass;
            position.x = fin.Position[0];
            position.y = fin.Position[2];
            position.z = fin.Position[1];
            size.height = fin.Size[2];
            size.width = fin.Size[1];
            size.length = fin.Size[0];
            sort = 1;
            stacking = true;
            turnover = true;
        }
    }

}
