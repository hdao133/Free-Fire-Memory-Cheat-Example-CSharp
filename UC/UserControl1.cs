using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xanax.UC
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private async Task PutTaskDelay(int Time)
        {
            await Task.Delay(Time);
        }
        private async Task<IntPtr> FUCK_IS_ALWAYS_REAL(string type)
        {
            string Bluestack = "HD-Player";
            string Bluestack2 = "HD-Player.exe";
            string memu = "MEmuHeadless";
            string Gameloop = "aow_exe";
            string SmartGaGA = "AndroidProcess.exe";
            string ld = "LdVBoxHeadless.exe";
            IntPtr intPtr = IntPtr.Zero;
            uint num = 0u;
            IntPtr intPtr2 = CreateToolhelp32Snapshot(2u, 0u);
            if ((int)intPtr2 > 0)
            {
                ProcessEntry32 processEntry = default(ProcessEntry32);
                processEntry.dwSize = (uint)Marshal.SizeOf(processEntry);
                for (int num2 = Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Process32Next(intPtr2, ref processEntry))
                {
                    IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
                    Marshal.StructureToPtr(processEntry, intPtr3, fDeleteOld: true);
                    ProcessEntry32 processEntry2 = (ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(ProcessEntry32));
                    Marshal.FreeHGlobal(intPtr3);
                    if (processEntry2.szExeFile.Contains(Bluestack) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(memu) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Gameloop) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(Bluestack2) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(SmartGaGA) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                    if (processEntry2.szExeFile.Contains(ld) && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)processEntry2.th32ProcessID;
                    }
                }

                pid.Text = Convert.ToString(intPtr);
                await PutTaskDelay(1000);
                switch (type)
                {
                    case "AIMBOT":
                        changeMEMORY("62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0C 00 00 00 62 00 79 00 74 00 65 00 73 00 55 00 6E 00 6B 00 6E 00 6F 00 77 00 6E 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 00 00 ?? 00 00 ??", "62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64");
                        break;
                    case "AIMBOTDESATIVAR":
                        changeMEMORY2("62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0C 00 00 00 62 00 79 00 74 00 65 00 73 00 55 00 6E 00 6B 00 6E 00 6F 00 77 00 6E 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 00 00 ?? 00 00 ??", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73");
                        break;
                    case "AIMNECK":
                        changeMEMORY("62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0C 00 00 00 62 00 79 00 74 00 65 00 73 00 55 00 6E 00 6B 00 6E 00 6F 00 77 00 6E 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 00 00 ?? 00 00 ??", "62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B");
                        break;
                    case "AIMNECKDESATIVAR":
                        changeMEMORY2("62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 09 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0C 00 00 00 62 00 79 00 74 00 65 00 73 00 55 00 6E 00 6B 00 6E 00 6F 00 77 00 6E", "62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73");
                        break;
                    case "AIMHIP":
                        changeMEMORY("D7 93 32 F1", "6E 78 21 82");
                        break;
                    case "AIMHIPDESATIVAR":
                        changeMEMORY2("6E 78 21 82", "D7 93 32 F1");
                        break;
                    case "AIMBOT2X":
                        changeMEMORY("A0 42 00 00 C0 3F 33 33 13 40 00 00 C0 3F 00 00 80 3F", "A0 42 00 00 C0 3F E0 B1 FF FF 00 00 C0 3F 00 00 80 3F");
                        break;
                    case "AIMBOT2XDESATIVAR":
                        changeMEMORY2("A0 42 00 00 C0 3F E0 B1 FF FF 00 00 C0 3F 00 00 80 3F", "A0 42 00 00 C0 3F 33 33 13 40 00 00 C0 3F 00 00 80 3F");
                        break;
                    case "DAIMFOVSIDE1":
                        changeMEMORY2("30 F8 FF FF 29 5C 0F 3F 14 AE C7 3E F6 28 1C 3F", "AE 47 E1 3E 29 5C 0F 3F 14 AE C7 3E F6 28 1C 3F");
                        break;
                    //
                    case "DAIMFOVSIDE2":
                        changeMEMORY2("30 F8 FF FF A4 70 FD 3E AE", "AE 47 01 3F A4 70 FD 3E AE");
                        break;
                    //
                    case "DAIMFOVSIDE3":
                        changeMEMORY2("30 F8 FF FF F6 28 1C 3F 00 00 00 00 00 00", "14 AE C7 3E F6 28 1C 3F 00 00 00 00 00 00");
                        break;
                    //
                    case "AIMFOV":
                        changeMEMORY("AE 47 01 3F", "80 7B E1 FF FF FF FF FF");
                        break;
                    case "AIMLOCK":
                        changeMEMORY("00 00 20 41 00 00 A0 41", "00 00 F0 41 00 00 A0 41");
                        break;
                    case "AIMLOCKDESATIVAR":
                        changeMEMORY2("00 00 F0 41 00 00 A0 41", "00 00 20 41 00 00 A0 41");
                        break;
                    case "PRECISION":
                        changeMEMORY("00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41", "00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45");
                        break;
                    case "PRECISIONDESATIVAR":
                        changeMEMORY2("00 00 71 41 00 00 0F 38 00 00 72 41 00 00 47 45", "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41");
                        break;
                    case "NORECOIL":
                        changeMEMORY("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED");
                        break;
                    case "NORECOILDESATIVAR":
                        changeMEMORY2("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED");
                        break;
                    case "FLY":
                        changeMEMORY("9A 99 99 3E 00 00 00 3F 00 00 34 42 CD CC CC", "00 00 80 40 00 00 00 3F 00 00 34 42 CD CC CC");
                        break;
                    case "FLYDESATIVAR":
                        changeMEMORY2("00 00 80 40 00 00 00 3F 00 00 34 42 CD CC CC", "9A 99 99 3E 00 00 00 3F 00 00 34 42 CD CC CC");
                        break;
                    case "FIXAIM":
                        changeMEMORY("00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41", "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 00");
                        break;
                    case "FIXAIMDESATIVAR":
                        changeMEMORY2("00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 00", "00 00 70 41 00 00 0C 42 00 00 20 41 00 00 A0 41");
                        break;
                    case "BYPASS":
                        changeMEMORY("A8 00 9F E5 00 20 A0 E3 00 00 9F E7 00 10 90 E5 0A 00 A0 E3", "A8 00 9F E5 00 20 A0 E3 00 00 9F E7 00 10 90 E5 00 F0 20 E3");
                        break;
                    case "BYPASSDESATIVAR":
                        changeMEMORY2("A8 00 9F E5 00 20 A0 E3 00 00 9F E7 00 10 90 E5 00 F0 20 E3", "A8 00 9F E5 00 20 A0 E3 00 00 9F E7 00 10 90 E5 0A 00 A0 E3");
                        break;
                        break;
                    case "SENSIPRO":
                        changeMEMORY("DB 0F 49 40 DB 0F 49 40", "00 00 A0 40 00 00 A0 40");
                        break;
                    case "DESATIVARSENSIPRO":
                        changeMEMORY2("00 00 A0 40 00 00 A0 40", "DB 0F 49 40 DB 0F 49 40");
                        break;
                    case "AIM50":
                        changeMEMORY("00 00 80 3F 00 00 00 00 00 00 80 3F 00 00 40 3F", "00 00 00 00 00 00 00 00 00 00 00 00 04 00 00 00");
                        break;
                    case "DAIM50":
                        changeMEMORY2("00 00 00 00 00 00 00 00 00 00 00 00 04 00 00 00", "00 00 80 3F 00 00 00 00 00 00 80 3F 00 00 40 3F");
                        break;
                    case "CAMERAHACK":
                        changeMEMORY("DB 0F 49 40 10 2A 00 EE", "00 00 A0 40 10 2A 00 EE");
                        break;
                    case "CAMERAHACKDESATIVA":
                        changeMEMORY2("00 00 A0 40 10 2A 00 EE", "DB 0F 49 40 10 2A 00 EE");
                        break;
                    case "VISION":
                        changeMEMORY("DB 0F 49 40", "00 00 A0 40");
                        break;
                    case "DVISION":
                        changeMEMORY("00 00 A0 40", "DB 0F 49 40");
                        break;
                    case "ANTENAMALE":
                        changeMEMORY("00 00 80 3F CF F7 AD 34", "33 33 34 43 CF F7 AD 34");
                        break;
                    case "DESATIVARANTENAMALE":
                        changeMEMORY2("33 33 34 43 CF F7 AD 34", "00 00 80 3F CF F7 AD 34");
                        break;
                    case "ANTENAFEMALE":
                        changeMEMORY("00 00 80 3F 6A 48 16 3F CD 74 D6 BD", "33 33 34 43 6A 48 16 3F CD 74 D6 BD");
                        break;
                    case "DESATIVARANTENAFEMALE":
                        changeMEMORY2("33 33 34 43 6A 48 16 3F CD 74 D6 BD", "00 00 80 3F 6A 48 16 3F CD 74 D6 BD");
                        break;
                    case "DESATIVARANTENAHEAD":
                        changeMEMORY("00 00 80 3F FB 67 13 3F 0A B8 05 3E 85 9D 4E BF", "CD AC EE 44 FB 67 13 3F 0A B8 05 3E 85 9D 4E BF");
                        break;
                    case "ESPDROP":
                        changeMEMORY("69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00", "65 00 66 00 66 00 65 00 63 00 74 00 73 00 2F 00 62 00 72 00 5F 00 61 00 69 00 72 00 64 00 72 00 6F 00 70 00 6C 00 69 00 67 00 68 00 74 00 6C 00 65 00 76 00 65 00 6C 00 31 00 00 00 00 00 00 00 00 00");
                        break;
                    case "ESPDROPDESATIVAR":
                        changeMEMORY2("69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00", "65 00 66 00 66 00 65 00 63 00 74 00 73 00 2F 00 62 00 72 00 5F 00 61 00 69 00 72 00 64 00 72 00 6F 00 70 00 6C 00 69 00 67 00 68 00 74 00 6C 00 65 00 76 00 65 00 6C 00 31 00 00 00 00 00 00 00 00 00");
                        break;
                    case "SKY":
                        changeMEMORY("0A D7 23 3C BD 37 86 35 00", "0A D7 23 3C 00 00 80 BF 00 20 A0 E3");
                        break;
                    case "SKYDESATIVAR":
                        changeMEMORY2("0A D7 23 3C 00 00 80 BF 00 20 A0 E3", "0A D7 23 3C BD 37 86 35 00");
                        break;
                    case "NOYELLOW":
                        changeMEMORY("96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", "96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00");
                        break;
                    case "NOYELLOWDESATIVAR":
                        changeMEMORY2("96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", "96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F");
                        break;
                    case "FAKEDAMAGE":
                        changeMEMORY("00 00 B0 40 00 00 80 3F 00 00 40 3F 00 00 80 3F", "23 C7 0A 5F 23 C7 0A 5F 00 00 40 3F 00 00 80 3F");
                        break;
                    case "FAKEDAMAGEDESATIVAR":
                        changeMEMORY2("23 C7 0A 5F 23 C7 0A 5F 00 00 40 3F 00 00 80 3F", "00 00 B0 40 00 00 80 3F 00 00 40 3F 00 00 80 3F");
                        break;


                }
            }
            return intPtr;
        }
        public async void Aplicar(string type)
        {
            x = 0;
            await FUCK_IS_ALWAYS_REAL(type);
        }
        private async void changeMEMORY(string search, string replace)
        {
            bool i = false;
            int counter = 1;
            if (Convert.ToInt32(pid.Text) == 0)
            {
                this.Alert("Open first Emulador...", Form_Alert.enmType.Error);
                Console.Beep();
            }

            MemLib.OpenProcess(Convert.ToInt32(pid.Text));

            IEnumerable<long> enumerable = await MemLib.AoBScan(0L, 140737488355327L, (search), true, true, string.Empty);
            string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
            Mem.MemoryProtection memoryProtection;
            MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
            foreach (long num in enumerable)
            {
                MemLib.WriteMemory(num.ToString("X"), "bytes", (replace), string.Empty, null);
                i = true;
            }
            if (i)
            {
                this.Alert("Successfully Applied", Form_Alert.enmType.Success);
                Console.Beep();
            }
            else if (counter < 4)
            {
                this.Alert("Error Applied...", Form_Alert.enmType.Warning);
                Console.Beep();
            }
            else
            {
                this.Alert("Failed!", Form_Alert.enmType.Warning);
                Console.Beep();
            }
            Mem.MemoryProtection memoryProtection2;
            MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            MemLib.CloseProcess();
        }
        private async void changeMEMORY2(string search, string replace)
        {
            bool i = false;
            int counter = 1;
            if (Convert.ToInt32(pid.Text) == 0)
            {
                this.Alert("Open first Emulador...", Form_Alert.enmType.Error);
                Console.Beep();
            }

            MemLib.OpenProcess(Convert.ToInt32(pid.Text));

            IEnumerable<long> enumerable = await MemLib.AoBScan(0L, 140737488355327L, (search), true, true, string.Empty);
            string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
            Mem.MemoryProtection memoryProtection;
            MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
            foreach (long num in enumerable)
            {
                MemLib.WriteMemory(num.ToString("X"), "bytes", (replace), string.Empty, null);
                i = true;
            }
            if (i)
            {
                this.Alert("Successfully Disabled", Form_Alert.enmType.Success);
                Console.Beep();
            }
            else if (counter < 4)
            {
                this.Alert("Error on Deactivation...", Form_Alert.enmType.Warning);
                Console.Beep();

            }
            else
            {
                this.Alert("Failed!", Form_Alert.enmType.Warning);
                Console.Beep();
            }
            Mem.MemoryProtection memoryProtection2;
            MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
            MemLib.CloseProcess();
        }

        private int x;
        public Mem MemLib = new Mem();
        private static string string_0;


        [DllImport("KERNEL32.DLL")]
        public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);

        public struct ProcessEntry32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHealabel1;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }


        private static Mem Memory = new Mem();

        private void TrackSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            if (TrackSpeed.Value == 0)
            {
                TxtSpeed.Text = "Speed - 2X";
            }
            if (TrackSpeed.Value == 1)
            {
                TxtSpeed.Text = "Speed - 5X";
            }
            if (TrackSpeed.Value == 2)
            {
                TxtSpeed.Text = "Speed - 10X";
            }
            if (TrackSpeed.Value == 3)
            {
                TxtSpeed.Text = "Speed - 20X";
            }
            if (TrackSpeed.Value == 4)
            {
                TxtSpeed.Text = "Speed - 100X";
            }
        }

        private void BtnExactly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSensiPro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSensiMax_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnAntenaH_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnAntenaH.Checked)
            {
                this.Alert("Applying ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("ANTENAMALE");
            }
            else
            {
                this.Alert("Deactivating ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("DESATIVARANTENAMALE");
            }
            
        }

        private void BtnAntenaM_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnAntenaM.Checked)
            {
                this.Alert("Applying ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("ANTENAFEMALE");
            }
            else
            {
                this.Alert("Deactivating ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("DESATIVARANTENAFEMALE");
            }
        }

        private void BtnNightMode_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnNightMode.Checked)
            {
                this.Alert("Applying ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("SKY");
            }
            else
            {
                this.Alert("Deactivating ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("SKYDESATIVAR");
            }
        }

        private void BtnCrossHairHd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnIncreaseVision_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnIncreaseVision.Checked)
            {
                this.Alert("Applying ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("CAMERAHACK");
            }
            else
            {
                this.Alert("Deactivating ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("CAMERAHACKDESATIVA");
            }
        }

        private void BtnMedikitFast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnMedikitRunning_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnFly_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnFly.Checked)
            {
                this.Alert("Applying ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("FLY");
            }
            else
            {
                this.Alert("Deactivating ...", Form_Alert.enmType.Info);
                Console.Beep();
                Aplicar("FLYDESATIVAR");
            }
        }

        private void BtnFlyUnderground_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnApplySpeed_Click(object sender, EventArgs e)
        {
        }

        private void BtnDisableSpeed_Click(object sender, EventArgs e)
        {
        }
    }
}
