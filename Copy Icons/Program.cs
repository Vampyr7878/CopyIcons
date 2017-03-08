using System;
using System.IO;
using System.Xml.Serialization;

namespace Copy_Icons
{
    class Program
    {
        static Items items;
        static XmlSerializer xml;
        static string path = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\WoW Character Viewer Classic\WoW Character Viewer Classic\Data\";

        static void Main(string[] args)
        {
            CopyItemIcons("NeckItems.xml");
            CopyItemIcons("FingerItems.xml");
            CopyItemIcons("TrinketItems.xml");
            CopyItemIcons("BackItems.xml");
            CopyItemIcons("ClothChestItems.xml");
            CopyItemIcons("LeatherChestItems.xml");
            CopyItemIcons("MailChestItems.xml");
            CopyItemIcons("PlateChestItems.xml");
            CopyItemIcons("ClothWristItems.xml");
            CopyItemIcons("LeatherWristItems.xml");
            CopyItemIcons("MailWristItems.xml");
            CopyItemIcons("PlateWristItems.xml");
            CopyItemIcons("ClothHandsItems.xml");
            CopyItemIcons("LeatherHandsItems.xml");
            CopyItemIcons("MailHandsItems.xml");
            CopyItemIcons("PlateHandsItems.xml");
            CopyItemIcons("ClothWaistItems.xml");
            CopyItemIcons("LeatherWaistItems.xml");
            CopyItemIcons("MailWaistItems.xml");
            CopyItemIcons("PlateWaistItems.xml");
            CopyItemIcons("ClothLegsItems.xml");
            CopyItemIcons("LeatherLegsItems.xml");
            CopyItemIcons("MailLegsItems.xml");
            CopyItemIcons("PlateLegsItems.xml");
            CopyItemIcons("ClothFeetItems.xml");
            CopyItemIcons("LeatherFeetItems.xml");
            CopyItemIcons("MailFeetItems.xml");
            CopyItemIcons("PlateFeetItems.xml");
            CopyItemIcons("ShirtItems.xml");
            CopyItemIcons("TabardItems.xml");
            CopyItemIcons("ClothHeadItems.xml");
            CopyItemIcons("LeatherHeadItems.xml");
            CopyItemIcons("MailHeadItems.xml");
            CopyItemIcons("PlateHeadItems.xml");
            CopyItemIcons("ClothShoulderItems.xml");
            CopyItemIcons("LeatherShoulderItems.xml");
            CopyItemIcons("MailShoulderItems.xml");
            CopyItemIcons("PlateShoulderItems.xml");
            CopyItemIcons("DaggerItems.xml");
            CopyItemIcons("FistWeaponItems.xml");
            CopyItemIcons("OneHandedAxeItems.xml");
            CopyItemIcons("OneHandedMaceItems.xml");
            CopyItemIcons("OneHandedSwordItems.xml");
            CopyItemIcons("PolearmItems.xml");
            CopyItemIcons("StaffItems.xml");
            CopyItemIcons("TwoHandedAxeItems.xml");
            CopyItemIcons("TwoHandedMaceItems.xml");
            CopyItemIcons("TwoHandedSwordItems.xml");
            CopyItemIcons("BowItems.xml");
            CopyItemIcons("CrossbowItems.xml");
            CopyItemIcons("GunItems.xml");
            CopyItemIcons("ThrownItems.xml");
            CopyItemIcons("WandItems.xml");
            CopyItemIcons("ShieldItems.xml");
            CopyItemIcons("HeldInOffHandItems.xml");
            CopyItemIcons("IdolItems.xml");
            CopyItemIcons("LibramItems.xml");
            CopyItemIcons("TotemItems.xml");
            CopyItemIcons("ArrowItems.xml");
            CopyItemIcons("BulletItems.xml");
            CopyItemIcons("ReagentItems.xml");
            CopyItemIcons("BagItems.xml");
            CopyItemIcons("MountItems.xml");
        }

        static void CopyItemIcons(string file)
        {
            xml = new XmlSerializer(typeof(Items));
            using(StreamReader reader = new StreamReader(path + file))
            {
                items = (Items)xml.Deserialize(reader);
            }
            foreach(ItemsItem item in items.Item) {
                CopyIcon(item.Icon);
            }
        }

        static void CopyIcon(string icon)
        {
            string source = @"G:\MPQ\Interface\Icons\" + icon + ".png";
            string destination = @"C:\Users\wojte\Documents\Visual Studio 2013\Projects\WoW Character Viewer Classic\WoW Character Viewer Classic\Icons\" + icon + ".png";
            File.Copy(source, destination, true);
            Console.WriteLine(icon + " copied");
        }
    }
}
