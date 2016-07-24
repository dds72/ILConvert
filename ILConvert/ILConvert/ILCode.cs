using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILConvert
{
  class ILCode
  {
    public int Opcode { get; set; }
    public string Instruction { get; set; }
    public string InstructionHash { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
  }
}
