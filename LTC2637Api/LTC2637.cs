using BaseApi;
using BitField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTC2637Api
{
    public class LTC2637
    {
        [BitFieldNumberOfBitsAttribute(8)]
        public struct CommandAddressRegister : IBitField
        {

            [BitFieldInfo(0, 1)]
            public byte A0 { get; set; }
            [BitFieldInfo(1, 1)]
            public byte A1 { get; set; }
            [BitFieldInfo(2, 1)]
            public byte A2 { get; set; }
            [BitFieldInfo(3, 2)]
            public byte A3 { get; set; }
            [BitFieldInfo(4, 2)]
            public byte C0 { get; set; }
            [BitFieldInfo(5, 1)]
            public byte C1 { get; set; }
            [BitFieldInfo(6, 1)]
            public byte C2 { get; set; }
            [BitFieldInfo(7, 1)]
            public byte C3 { get; set; }

        }
        
        public enum Command
        {
            WriteToInputRegisterN,
            PowerUpDACRegister,
            WriteToInputRegisterN_PowerUpAll,
            WriteTo_PowerUpDACRegisterN,
            PowerDownN,
            PowerDownAll,
            PowerUpInternalReference,
            PowerDownInternalReference,
            NoOperation
        };

        public enum DAC
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            All
        };

        CommandAddressRegister m_cmdAddReg = new CommandAddressRegister();

        BaseApi.I2CBase m_i2c;
        byte m_slaveAddress = 0;

        public LTC2637(byte slaveAddress)
        {
           
            m_i2c = new DiolanI2CController(slaveAddress);
 
        }

        private void SetCommandAndDac(Command command, DAC dac)
        {
            switch (command)
            {
                case Command.WriteToInputRegisterN:
                    m_cmdAddReg.C0 = 0;
                    m_cmdAddReg.C1 = 0;
                    m_cmdAddReg.C2 = 0;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.PowerUpDACRegister:
                    m_cmdAddReg.C0 = 1;
                    m_cmdAddReg.C1 = 0;
                    m_cmdAddReg.C2 = 0;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.WriteToInputRegisterN_PowerUpAll:
                    m_cmdAddReg.C0 = 0;
                    m_cmdAddReg.C1 = 1;
                    m_cmdAddReg.C2 = 0;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.WriteTo_PowerUpDACRegisterN:
                    m_cmdAddReg.C0 = 1;
                    m_cmdAddReg.C1 = 1;
                    m_cmdAddReg.C2 = 0;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.PowerDownN:
                    m_cmdAddReg.C0 = 0;
                    m_cmdAddReg.C1 = 0;
                    m_cmdAddReg.C2 = 1;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.PowerDownAll:
                    m_cmdAddReg.C0 = 1;
                    m_cmdAddReg.C1 = 0;
                    m_cmdAddReg.C2 = 1;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.PowerUpInternalReference:
                    m_cmdAddReg.C0 = 0;
                    m_cmdAddReg.C1 = 1;
                    m_cmdAddReg.C2 = 1;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.PowerDownInternalReference:
                    m_cmdAddReg.C0 = 1;
                    m_cmdAddReg.C1 = 1;
                    m_cmdAddReg.C2 = 1;
                    m_cmdAddReg.C3 = 0;
                    break;
                case Command.NoOperation:
                    m_cmdAddReg.C0 = 1;
                    m_cmdAddReg.C1 = 1;
                    m_cmdAddReg.C2 = 1;
                    m_cmdAddReg.C3 = 1;
                    break;
                default:
                    break;
            }

            switch (dac)
            {
                case DAC.A:
                    m_cmdAddReg.A0 = 0;
                    m_cmdAddReg.A1 = 0;
                    m_cmdAddReg.A2 = 0;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.B:
                    m_cmdAddReg.A0 = 1;
                    m_cmdAddReg.A1 = 0;
                    m_cmdAddReg.A2 = 0;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.C:
                    m_cmdAddReg.A0 = 0;
                    m_cmdAddReg.A1 = 1;
                    m_cmdAddReg.A2 = 0;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.D:
                    m_cmdAddReg.A0 = 1;
                    m_cmdAddReg.A1 = 1;
                    m_cmdAddReg.A2 = 0;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.E:
                    m_cmdAddReg.A0 = 0;
                    m_cmdAddReg.A1 = 0;
                    m_cmdAddReg.A2 = 1;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.F:
                    m_cmdAddReg.A0 = 1;
                    m_cmdAddReg.A1 = 0;
                    m_cmdAddReg.A2 = 1;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.G:
                    m_cmdAddReg.A0 = 0;
                    m_cmdAddReg.A1 = 1;
                    m_cmdAddReg.A2 = 1;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.H:
                    m_cmdAddReg.A0 = 1;
                    m_cmdAddReg.A1 = 1;
                    m_cmdAddReg.A2 = 1;
                    m_cmdAddReg.A3 = 0;
                    break;
                case DAC.All:
                    m_cmdAddReg.A0 = 1;
                    m_cmdAddReg.A1 = 1;
                    m_cmdAddReg.A2 = 1;
                    m_cmdAddReg.A3 = 1;
                    break;
                default:
                    break;
            }
        }

        public void Write(Command command, DAC dac, byte msData, byte lsData)
        {
            //Populating the commands and DAC bits
            SetCommandAndDac(command, dac);

            //Format: 0:Address, 1:Command+DAC, 2:MS Data, 3:LS Data
            byte[] data = { 0, 0, 0 };
            data[0] = m_cmdAddReg.ToUInt8();
            data[1] = msData;
            data[2] = lsData;

            m_i2c.Write(m_slaveAddress, data);
        }
    }
}
