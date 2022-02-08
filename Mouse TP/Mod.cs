using MelonLoader;
using MouseTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[assembly: MelonInfo(typeof(Mod), "MouseTP", "1.0", "Blaze#0666", "https://discord.gg/8Tuyv6Xc2T")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace MouseTP
{
    public class Mod : MelonMod
    {
        public override void OnUpdate()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0 != null && RoomManager.field_Internal_Static_ApiWorldInstance_0 != null)
            {
                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                    if (Physics.Raycast(ray, out RaycastHit raycastHit)) VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = raycastHit.point;
                }
            }
        }
    }
}
