using System.Globalization;
using System.Net.Sockets;

namespace task1
{
    internal class Program
    {
        public interface CanShoot
        {
            public string Shoot();
        }
        public interface CanDive
        {
            public string Dive();
        }

        public interface CanDrive
        {
            public string Drive();
        }

        public interface CanSwim
        {
            public string Swim();
        }

        public interface CanFly
        {
            public string Fly();
        }
        abstract class vehicle
        {
            public string name;
            public int hp;
            public string engineName;

            public virtual string start()
            {
                return "started";
            }
        }
        abstract class boat : vehicle, CanSwim
        {
            public virtual string Swim()
            {
                    return "swimming";
            }
        }

        abstract class plane : vehicle, CanFly
        {
            public virtual string Fly()
            {
                return "i fly";
            }
        }

        abstract class fighterJet : plane, CanShoot
        {
            public int rockets;
            public virtual string Shoot()
            {
                return "im shooting but in a jet";
            }
        }
        
        abstract class car : vehicle, CanDrive
        {
            public int wheels;
            public virtual string Drive()
            {
                return "i drive";
            }
        }

        abstract class tank : car, CanShoot
        {
            public int ammo;
            public virtual string Shoot()
            {
                return "im shooting";
            }
        }

        class rhino : tank
        {
            public rhino(string name1, int hp1, string engineName1, int wheels1, int ammo1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
                wheels = wheels1;
                ammo = ammo1;
            }
            public override string Shoot()
            {
                return "KABAM";
            }
            public override string Drive()
            {
                return "trrrrrrrrrrrrr";
            }
            public override string start()
            {
                return "BEEEEAAAASTT!!!";
            }
        }

        class minionCar : car
        {
            public minionCar(string name1, int hp1, string engineName1, int wheels1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
                wheels = wheels1;
            }
            public override string Drive()
            {
                return "vroom vroom";
            }
            public override string start()
            {
                return "clown noise";
            }
        }

        class superCar : car, CanSwim, CanFly
        {
            public superCar(string name1, int hp1, string engineName1, int wheels1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
                wheels = wheels1;
            }
            public string Swim()
            {
                return "super swim!";
            }
            public string Fly()
            {
                return "super fly!";
            }
            public override string Drive()
            {
                return "super drive!";
            }
            public override string start()
            {
                return "SUPERMAN!!!!";
            }
        }

        class jetGM_099 : fighterJet
        {
            public jetGM_099(string name1, int hp1, string engineName1, int rockets1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
                rockets = rockets1;
            }
            public override string Shoot()
            {
                rockets--;
                return "tratatattatata";
            }
            public override string Fly()
            {
                return "fwhoooosh!";
            }
            public override string start()
            {
                return "AERRRRGH";
            }
        }

        class police_boat : boat
        {
            public police_boat(string name1, int hp1, string engineName1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
            }
            public override string Swim()
            {
                return "gluglu";
            }
            public override string start()
            {
                return "weee woo wee wooo";
            }
        }

        class submarine : boat, CanDive
        {
            public submarine(string name1, int hp1, string engineName1)
            {
                name = name1;
                hp = hp1;
                engineName = engineName1;
            }
            public string Dive()
            {
                return "descending!";
            }
            public override string start()
            {
                return "glugluglgulglu";
            }
        }
        static void Main(string[] args)
        {
            vehicle[] vehicles = { new rhino("tank", 999, "beast", 8, 999), new jetGM_099("jet", 150, "strong", 30), new minionCar("silly", 20, "funny", 4), new superCar("ultracar", 9001, "god", 20), new submarine("underwater boat", 40, "boomboomV4"), new police_boat("justice", 80, "order")};
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.start());
            }
            
        }
    }
}