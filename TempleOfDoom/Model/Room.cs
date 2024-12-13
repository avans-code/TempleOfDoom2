namespace TempleOfDoom.Model
{
    public class Room
    {
        public int id { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Item[] items { get; set; }
        public List<Door> doorsInRoom { get; set; }
        public Dictionary<Connection, Room> connectedRooms { get; set; }

        public Room(int id, string type, int width, int height, Item[] items,
            List<Door> doorsInRoom, Dictionary<Connection, Room> connectedRooms)
        {
            this.id = id;
            this.type = type;
            this.width = width;
            this.height = height;
            this.items = items;
            this.connectedRooms = connectedRooms;
        }

        public List<Item> checkForItem()
        {
            return null;
        }
        public Room getNextRoom(Connection connection)
        {

            if (connectedRooms.ContainsKey(connection))
            {
                return connectedRooms[connection];
            }
            else
            {
                return null;
            }
        }
        public void addConnection(Connection direction, Room connectedRoom)
        {
            connectedRooms[direction] = connectedRoom;
        }


    }
}
