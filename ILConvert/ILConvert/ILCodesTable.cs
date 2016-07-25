using System.Collections.Generic;

namespace ILConvert
{
  static class ILCodesTable
  {
    public static List<ILCode> codesTable = new List<ILCode>() {
      new ILCode
        {
          Opcode = 0x58,
          Instruction = "add",
          InstructionHash = "add",
          Description = "Add two values, returning a new value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD6,
          Instruction = "add.ovf",
          InstructionHash = "add.ovf",
          Description = "Add signed integer values with overflow check.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD7,
          Instruction = "add.ovf.un",
          InstructionHash = "add.ovf.un",
          Description = "Add unsigned integer values with overflow check.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x5F,
          Instruction = "and",
          InstructionHash = "and",
          Description = "Bitwise AND of two integral values, returns an integral value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE00,
          Instruction = "arglist",
          InstructionHash = "arglist",
          Description = "Return argument list handle for the current method.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3B,
          Instruction = "beq <int32 (target)>",
          InstructionHash = "beq",
          Description = "Branch to target if equal.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2E,
          Instruction = "beq.s <int8 (target)>",
          InstructionHash = "beq.s",
          Description = "Branch to target if equal, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3C,
          Instruction = "bge <int32 (target)>",
          InstructionHash = "bge",
          Description = "Branch to target if greater than or equal to.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2F,
          Instruction = "bge.s <int8 (target)>",
          InstructionHash = "bge.s",
          Description = "Branch to target if greater than or equal to, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x41,
          Instruction = "bge.un <int32 (target)>",
          InstructionHash = "bge.un",
          Description = "Branch to target if greater than or equal to (unsigned or unordered).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x34,
          Instruction = "bge.un.s <int8 (target)>",
          InstructionHash = "bge.un.s",
          Description = "Branch to target if greater than or equal to (unsigned or unordered), short form",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3D,
          Instruction = "bgt <int32 (target)>",
          InstructionHash = "bgt",
          Description = "Branch to target if greater than.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x30,
          Instruction = "bgt.s <int8 (target)>",
          InstructionHash = "bgt.s",
          Description = "Branch to target if greater than, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x42,
          Instruction = "bgt.un <int32 (target)>",
          InstructionHash = "bgt.un",
          Description = "Branch to target if greater than (unsigned or unordered).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x35,
          Instruction = "bgt.un.s <int8 (target)>",
          InstructionHash = "bgt.un.s",
          Description = "Branch to target if greater than (unsigned or unordered), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3E,
          Instruction = "ble <int32 (target)>",
          InstructionHash = "ble",
          Description = "Branch to target if less than or equal to.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x31,
          Instruction = "ble.s <int8 (target)>",
          InstructionHash = "ble.s",
          Description = "Branch to target if less than or equal to, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x43,
          Instruction = "ble.un <int32 (target)>",
          InstructionHash = "ble.un",
          Description = "Branch to target if less than or equal to (unsigned or unordered).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x36,
          Instruction = "ble.un.s <int8 (target)>",
          InstructionHash = "ble.un.s",
          Description = "Branch to target if less than or equal to (unsigned or unordered), short form",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3F,
          Instruction = "blt <int32 (target)>",
          InstructionHash = "blt",
          Description = "Branch to target if less than.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x32,
          Instruction = "blt.s <int8 (target)>",
          InstructionHash = "blt.s",
          Description = "Branch to target if less than, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x44,
          Instruction = "blt.un <int32 (target)>",
          InstructionHash = "blt.un",
          Description = "Branch to target if less than (unsigned or unordered).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x37,
          Instruction = "blt.un.s <int8 (target)>",
          InstructionHash = "blt.un.s",
          Description = "Branch to target if less than (unsigned or unordered), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x40,
          Instruction = "bne.un <int32 (target)>",
          InstructionHash = "bne.un",
          Description = "Branch to target if unequal or unordered.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x33,
          Instruction = "bne.un.s <int8 (target)>",
          InstructionHash = "bne.un.s",
          Description = "Branch to target if unequal or unordered, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x8C,
          Instruction = "box <typeTok>",
          InstructionHash = "box",
          Description = "Convert a boxable value to its boxed form",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x38,
          Instruction = "br <int32 (target)>",
          InstructionHash = "br",
          Description = "Branch to target.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2B,
          Instruction = "br.s <int8 (target)>",
          InstructionHash = "br.s",
          Description = "Branch to target, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x01,
          Instruction = "break",
          InstructionHash = "break",
          Description = "Inform a debugger that a breakpoint has been reached.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x39,
          Instruction = "brfalse <int32 (target)>",
          InstructionHash = "brfalse",
          Description = "Branch to target if value is zero (false).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2C,
          Instruction = "brfalse.s <int8 (target)>",
          InstructionHash = "brfalse.s",
          Description = "Branch to target if value is zero (false), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3A,
          Instruction = "brinst <int32 (target)>",
          InstructionHash = "brinst",
          Description = "Branch to target if value is a non-null object reference (alias for brtrue).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2D,
          Instruction = "brinst.s <int8 (target)>",
          InstructionHash = "brinst.s",
          Description = "Branch to target if value is a non-null object reference, short form (alias for brtrue.s).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x39,
          Instruction = "brnull <int32 (target)>",
          InstructionHash = "brnull",
          Description = "Branch to target if value is null (alias for brfalse).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2C,
          Instruction = "brnull.s <int8 (target)>",
          InstructionHash = "brnull.s",
          Description = "Branch to target if value is null (alias for brfalse.s), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x3A,
          Instruction = "brtrue <int32 (target)>",
          InstructionHash = "brtrue",
          Description = "Branch to target if value is non-zero (true).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2D,
          Instruction = "brtrue.s <int8 (target)>",
          InstructionHash = "brtrue.s",
          Description = "Branch to target if value is non-zero (true), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x39,
          Instruction = "brzero <int32 (target)>",
          InstructionHash = "brzero",
          Description = "Branch to target if value is zero (alias for brfalse).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2C,
          Instruction = "brzero.s <int8 (target)>",
          InstructionHash = "brzero.s",
          Description = "Branch to target if value is zero (alias for brfalse.s), short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x28,
          Instruction = "call <method>",
          InstructionHash = "call",
          Description = "Call method described by method.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x29,
          Instruction = "calli <callsitedescr>",
          InstructionHash = "calli",
          Description = "Call method indicated on the stack with arguments described by callsitedescr.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6F,
          Instruction = "callvirt <method>",
          InstructionHash = "callvirt",
          Description = "Call a method associated with an object.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x74,
          Instruction = "castclass <class>",
          InstructionHash = "castclass",
          Description = "Cast obj to class.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE01,
          Instruction = "ceq",
          InstructionHash = "ceq",
          Description = "Push 1 (of type int32) if value1 equals value2, else push 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE02,
          Instruction = "cgt",
          InstructionHash = "cgt",
          Description = "Push 1 (of type int32) if value1 > value2, else push 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE03,
          Instruction = "cgt.un",
          InstructionHash = "cgt.un",
          Description = "Push 1 (of type int32) if value1 > value2, unsigned or unordered, else push 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xC3,
          Instruction = "ckfinite",
          InstructionHash = "ckfinite",
          Description = "Throw ArithmeticException if value is not a finite number.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE04,
          Instruction = "clt",
          InstructionHash = "clt",
          Description = "Push 1 (of type int32) if value1 < value2, else push 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE05,
          Instruction = "clt.un",
          InstructionHash = "clt.un",
          Description = "Push 1 (of type int32) if value1 < value2, unsigned or unordered, else push 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE16,
          Instruction = "constrained. <thisType>",
          InstructionHash = "constrained.",
          Description = "Call a virtual method on a type constrained to be type T",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0xD3,
          Instruction = "conv.i",
          InstructionHash = "conv.i",
          Description = "Convert to native int, pushing native int on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x67,
          Instruction = "conv.i1",
          InstructionHash = "conv.i1",
          Description = "Convert to int8, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x68,
          Instruction = "conv.i2",
          InstructionHash = "conv.i2",
          Description = "Convert to int16, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x69,
          Instruction = "conv.i4",
          InstructionHash = "conv.i4",
          Description = "Convert to int32, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6A,
          Instruction = "conv.i8",
          InstructionHash = "conv.i8",
          Description = "Convert to int64, pushing int64 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD4,
          Instruction = "conv.ovf.i",
          InstructionHash = "conv.ovf.i",
          Description = "Convert to a native int (on the stack as native int) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x8A,
          Instruction = "conv.ovf.i.un",
          InstructionHash = "conv.ovf.i.un",
          Description = "Convert unsigned to a native int (on the stack as native int) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB3,
          Instruction = "conv.ovf.i1",
          InstructionHash = "conv.ovf.i1",
          Description = "Convert to an int8 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x82,
          Instruction = "conv.ovf.i1.un",
          InstructionHash = "conv.ovf.i1.un",
          Description = "Convert unsigned to an int8 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB5,
          Instruction = "conv.ovf.i2",
          InstructionHash = "conv.ovf.i2",
          Description = "Convert to an int16 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x83,
          Instruction = "conv.ovf.i2.un",
          InstructionHash = "conv.ovf.i2.un",
          Description = "Convert unsigned to an int16 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB7,
          Instruction = "conv.ovf.i4",
          InstructionHash = "conv.ovf.i4",
          Description = "Convert to an int32 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x84,
          Instruction = "conv.ovf.i4.un",
          InstructionHash = "conv.ovf.i4.un",
          Description = "Convert unsigned to an int32 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB9,
          Instruction = "conv.ovf.i8",
          InstructionHash = "conv.ovf.i8",
          Description = "Convert to an int64 (on the stack as int64) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x85,
          Instruction = "conv.ovf.i8.un",
          InstructionHash = "conv.ovf.i8.un",
          Description = "Convert unsigned to an int64 (on the stack as int64) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD5,
          Instruction = "conv.ovf.u",
          InstructionHash = "conv.ovf.u",
          Description = "Convert to a native unsigned int (on the stack as native int) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x8B,
          Instruction = "conv.ovf.u.un",
          InstructionHash = "conv.ovf.u.un",
          Description = "Convert unsigned to a native unsigned int (on the stack as native int) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB4,
          Instruction = "conv.ovf.u1",
          InstructionHash = "conv.ovf.u1",
          Description = "Convert to an unsigned int8 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x86,
          Instruction = "conv.ovf.u1.un",
          InstructionHash = "conv.ovf.u1.un",
          Description = "Convert unsigned to an unsigned int8 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB6,
          Instruction = "conv.ovf.u2",
          InstructionHash = "conv.ovf.u2",
          Description = "Convert to an unsigned int16 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x87,
          Instruction = "conv.ovf.u2.un",
          InstructionHash = "conv.ovf.u2.un",
          Description = "Convert unsigned to an unsigned int16 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xB8,
          Instruction = "conv.ovf.u4",
          InstructionHash = "conv.ovf.u4",
          Description = "Convert to an unsigned int32 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x88,
          Instruction = "conv.ovf.u4.un",
          InstructionHash = "conv.ovf.u4.un",
          Description = "Convert unsigned to an unsigned int32 (on the stack as int32) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xBA,
          Instruction = "conv.ovf.u8",
          InstructionHash = "conv.ovf.u8",
          Description = "Convert to an unsigned int64 (on the stack as int64) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x89,
          Instruction = "conv.ovf.u8.un",
          InstructionHash = "conv.ovf.u8.un",
          Description = "Convert unsigned to an unsigned int64 (on the stack as int64) and throw an exception on overflow.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x76,
          Instruction = "conv.r.un",
          InstructionHash = "conv.r.un",
          Description = "Convert unsigned integer to floating-point, pushing F on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6B,
          Instruction = "conv.r4",
          InstructionHash = "conv.r4",
          Description = "Convert to float32, pushing F on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6C,
          Instruction = "conv.r8",
          InstructionHash = "conv.r8",
          Description = "Convert to float64, pushing F on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xE0,
          Instruction = "conv.u",
          InstructionHash = "conv.u",
          Description = "Convert to native unsigned int, pushing native int on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD2,
          Instruction = "conv.u1",
          InstructionHash = "conv.u1",
          Description = "Convert to unsigned int8, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD1,
          Instruction = "conv.u2",
          InstructionHash = "conv.u2",
          Description = "Convert to unsigned int16, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6D,
          Instruction = "conv.u4",
          InstructionHash = "conv.u4",
          Description = "Convert to unsigned int32, pushing int32 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x6E,
          Instruction = "conv.u8",
          InstructionHash = "conv.u8",
          Description = "Convert to unsigned int64, pushing int64 on stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE17,
          Instruction = "cpblk",
          InstructionHash = "cpblk",
          Description = "Copy data from memory to memory.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x70,
          Instruction = "cpobj <typeTok>",
          InstructionHash = "cpobj",
          Description = "Copy a value type from src to dest.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x5B,
          Instruction = "div",
          InstructionHash = "div",
          Description = "Divide two values to return a quotient or floating-point result.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x5C,
          Instruction = "div.un",
          InstructionHash = "div.un",
          Description = "Divide two values, unsigned, returning a quotient.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x25,
          Instruction = "dup",
          InstructionHash = "dup",
          Description = "Duplicate the value on the top of the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xDC,
          Instruction = "endfault",
          InstructionHash = "endfault",
          Description = "End fault clause of an exception block.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE11,
          Instruction = "endfilter",
          InstructionHash = "endfilter",
          Description = "End an exception handling filter clause.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xDC,
          Instruction = "endfinally",
          InstructionHash = "endfinally",
          Description = "End finally clause of an exception block.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE18,
          Instruction = "initblk",
          InstructionHash = "initblk",
          Description = "Set all bytes in a block of memory to a given byte value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE15,
          Instruction = "initobj <typeTok>",
          InstructionHash = "initobj",
          Description = "Initialize the value at address dest.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x75,
          Instruction = "isinst <class>",
          InstructionHash = "isinst",
          Description = "Test if obj is an instance of class, returning null or an instance of that class or interface.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x27,
          Instruction = "jmp <method>",
          InstructionHash = "jmp",
          Description = "Exit current method and jump to the specified method.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE09,
          Instruction = "ldarg <uint16 (num)>",
          InstructionHash = "ldarg",
          Description = "Load argument numbered num onto the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x02,
          Instruction = "ldarg.0",
          InstructionHash = "ldarg.0",
          Description = "Load argument 0 onto the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x03,
          Instruction = "ldarg.1",
          InstructionHash = "ldarg.1",
          Description = "Load argument 1 onto the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x04,
          Instruction = "ldarg.2",
          InstructionHash = "ldarg.2",
          Description = "Load argument 2 onto the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x05,
          Instruction = "ldarg.3",
          InstructionHash = "ldarg.3",
          Description = "Load argument 3 onto the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0E,
          Instruction = "ldarg.s <uint8 (num)>",
          InstructionHash = "ldarg.s",
          Description = "Load argument numbered num onto the stack, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0A,
          Instruction = "ldarga <uint16 (argNum)>",
          InstructionHash = "ldarga",
          Description = "Fetch the address of argument argNum.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0F,
          Instruction = "ldarga.s <uint8 (argNum)>",
          InstructionHash = "ldarga.s",
          Description = "Fetch the address of argument argNum, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x20,
          Instruction = "ldc.i4 <int32 (num)>",
          InstructionHash = "ldc.i4",
          Description = "Push num of type int32 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x16,
          Instruction = "ldc.i4.0",
          InstructionHash = "ldc.i4.0",
          Description = "Push 0 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x17,
          Instruction = "ldc.i4.1",
          InstructionHash = "ldc.i4.1",
          Description = "Push 1 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x18,
          Instruction = "ldc.i4.2",
          InstructionHash = "ldc.i4.2",
          Description = "Push 2 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x19,
          Instruction = "ldc.i4.3",
          InstructionHash = "ldc.i4.3",
          Description = "Push 3 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1A,
          Instruction = "ldc.i4.4",
          InstructionHash = "ldc.i4.4",
          Description = "Push 4 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1B,
          Instruction = "ldc.i4.5",
          InstructionHash = "ldc.i4.5",
          Description = "Push 5 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1C,
          Instruction = "ldc.i4.6",
          InstructionHash = "ldc.i4.6",
          Description = "Push 6 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1D,
          Instruction = "ldc.i4.7",
          InstructionHash = "ldc.i4.7",
          Description = "Push 7 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1E,
          Instruction = "ldc.i4.8",
          InstructionHash = "ldc.i4.8",
          Description = "Push 8 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x15,
          Instruction = "ldc.i4.m1",
          InstructionHash = "ldc.i4.m1",
          Description = "Push -1 onto the stack as int32.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x15,
          Instruction = "ldc.i4.M1",
          InstructionHash = "ldc.i4.M1",
          Description = "Push -1 of type int32 onto the stack as int32 (alias for ldc.i4.m1).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x1F,
          Instruction = "ldc.i4.s <int8 (num)>",
          InstructionHash = "ldc.i4.s",
          Description = "Push num onto the stack as int32, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x21,
          Instruction = "ldc.i8 <int64 (num)>",
          InstructionHash = "ldc.i8",
          Description = "Push num of type int64 onto the stack as int64.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x22,
          Instruction = "ldc.r4 <float32 (num)>",
          InstructionHash = "ldc.r4",
          Description = "Push num of type float32 onto the stack as F.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x23,
          Instruction = "ldc.r8 <float64 (num)>",
          InstructionHash = "ldc.r8",
          Description = "Push num of type float64 onto the stack as F.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xA3,
          Instruction = "ldelem <typeTok>",
          InstructionHash = "ldelem",
          Description = "Load the element at index onto the top of the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x97,
          Instruction = "ldelem.i",
          InstructionHash = "ldelem.i",
          Description = "Load the element with type native int at index onto the top of the stack as a native int.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x90,
          Instruction = "ldelem.i1",
          InstructionHash = "ldelem.i1",
          Description = "Load the element with type int8 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x92,
          Instruction = "ldelem.i2",
          InstructionHash = "ldelem.i2",
          Description = "Load the element with type int16 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x94,
          Instruction = "ldelem.i4",
          InstructionHash = "ldelem.i4",
          Description = "Load the element with type int32 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x96,
          Instruction = "ldelem.i8",
          InstructionHash = "ldelem.i8",
          Description = "Load the element with type int64 at index onto the top of the stack as an int64.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x98,
          Instruction = "ldelem.r4",
          InstructionHash = "ldelem.r4",
          Description = "Load the element with type float32 at index onto the top of the stack as an F",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x99,
          Instruction = "ldelem.r8",
          InstructionHash = "ldelem.r8",
          Description = "Load the element with type float64 at index onto the top of the stack as an F.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9A,
          Instruction = "ldelem.ref",
          InstructionHash = "ldelem.ref",
          Description = "Load the element at index onto the top of the stack as an O. The type of the O is the same as the element type of the array pushed on the CIL stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x91,
          Instruction = "ldelem.u1",
          InstructionHash = "ldelem.u1",
          Description = "Load the element with type unsigned int8 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x93,
          Instruction = "ldelem.u2",
          InstructionHash = "ldelem.u2",
          Description = "Load the element with type unsigned int16 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x95,
          Instruction = "ldelem.u4",
          InstructionHash = "ldelem.u4",
          Description = "Load the element with type unsigned int32 at index onto the top of the stack as an int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x96,
          Instruction = "ldelem.u8",
          InstructionHash = "ldelem.u8",
          Description = "Load the element with type unsigned int64 at index onto the top of the stack as an int64 (alias for ldelem.i8).",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x8F,
          Instruction = "ldelema <class>",
          InstructionHash = "ldelema",
          Description = "Load the address of element at index onto the top of the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x7B,
          Instruction = "ldfld <field>",
          InstructionHash = "ldfld",
          Description = "Push the value of field of object (or value type) obj, onto the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x7C,
          Instruction = "ldflda <field>",
          InstructionHash = "ldflda",
          Description = "Push the address of field of object obj on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE06,
          Instruction = "ldftn <method>",
          InstructionHash = "ldftn",
          Description = "Push a pointer to a method referenced by method, on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4D,
          Instruction = "ldind.i",
          InstructionHash = "ldind.i",
          Description = "Indirect load value of type native int as native int on the stack",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x46,
          Instruction = "ldind.i1",
          InstructionHash = "ldind.i1",
          Description = "Indirect load value of type int8 as int32 on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x48,
          Instruction = "ldind.i2",
          InstructionHash = "ldind.i2",
          Description = "Indirect load value of type int16 as int32 on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4A,
          Instruction = "ldind.i4",
          InstructionHash = "ldind.i4",
          Description = "Indirect load value of type int32 as int32 on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4C,
          Instruction = "ldind.i8",
          InstructionHash = "ldind.i8",
          Description = "Indirect load value of type int64 as int64 on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4E,
          Instruction = "ldind.r4",
          InstructionHash = "ldind.r4",
          Description = "Indirect load value of type float32 as F on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4F,
          Instruction = "ldind.r8",
          InstructionHash = "ldind.r8",
          Description = "Indirect load value of type float64 as F on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x50,
          Instruction = "ldind.ref",
          InstructionHash = "ldind.ref",
          Description = "Indirect load value of type object ref as O on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x47,
          Instruction = "ldind.u1",
          InstructionHash = "ldind.u1",
          Description = "Indirect load value of type unsigned int8 as int32 on the stack",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x49,
          Instruction = "ldind.u2",
          InstructionHash = "ldind.u2",
          Description = "Indirect load value of type unsigned int16 as int32 on the stack",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4B,
          Instruction = "ldind.u4",
          InstructionHash = "ldind.u4",
          Description = "Indirect load value of type unsigned int32 as int32 on the stack",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x4C,
          Instruction = "ldind.u8",
          InstructionHash = "ldind.u8",
          Description = "Indirect load value of type unsigned int64 as int64 on the stack (alias for ldind.i8).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x8E,
          Instruction = "ldlen",
          InstructionHash = "ldlen",
          Description = "Push the length (of type native unsigned int) of array on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0C,
          Instruction = "ldloc <uint16 (indx)>",
          InstructionHash = "ldloc",
          Description = "Load local variable of index indx onto stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x06,
          Instruction = "ldloc.0",
          InstructionHash = "ldloc.0",
          Description = "Load local variable 0 onto stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x07,
          Instruction = "ldloc.1",
          InstructionHash = "ldloc.1",
          Description = "Load local variable 1 onto stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x08,
          Instruction = "ldloc.2",
          InstructionHash = "ldloc.2",
          Description = "Load local variable 2 onto stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x09,
          Instruction = "ldloc.3",
          InstructionHash = "ldloc.3",
          Description = "Load local variable 3 onto stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x11,
          Instruction = "ldloc.s <uint8 (indx)>",
          InstructionHash = "ldloc.s",
          Description = "Load local variable of index indx onto stack, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0D,
          Instruction = "ldloca <uint16 (indx)>",
          InstructionHash = "ldloca",
          Description = "Load address of local variable with index indx.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x12,
          Instruction = "ldloca.s <uint8 (indx)>",
          InstructionHash = "ldloca.s",
          Description = "Load address of local variable with index indx, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x14,
          Instruction = "ldnull",
          InstructionHash = "ldnull",
          Description = "Push a null reference on the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x71,
          Instruction = "ldobj <typeTok>",
          InstructionHash = "ldobj",
          Description = "Copy the value stored at address src to the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x7E,
          Instruction = "ldsfld <field>",
          InstructionHash = "ldsfld",
          Description = "Push the value of field on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x7F,
          Instruction = "ldsflda <field>",
          InstructionHash = "ldsflda",
          Description = "Push the address of the static field, field, on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x72,
          Instruction = "ldstr <string>",
          InstructionHash = "ldstr",
          Description = "Push a string object for the literal string.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xD0,
          Instruction = "ldtoken <token>",
          InstructionHash = "ldtoken",
          Description = "Convert metadata token to its runtime representation.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE07,
          Instruction = "ldvirtftn <method>",
          InstructionHash = "ldvirtftn",
          Description = "Push address of virtual method on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xDD,
          Instruction = "leave <int32 (target)>",
          InstructionHash = "leave",
          Description = "Exit a protected region of code.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xDE,
          Instruction = "leave.s <int8 (target)>",
          InstructionHash = "leave.s",
          Description = "Exit a protected region of code, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0F,
          Instruction = "localloc",
          InstructionHash = "localloc",
          Description = "Allocate space from the local memory pool.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xC6,
          Instruction = "mkrefany <class>",
          InstructionHash = "mkrefany",
          Description = "Push a typed reference to ptr of type class onto the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x5A,
          Instruction = "mul",
          InstructionHash = "mul",
          Description = "Multiply values.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD8,
          Instruction = "mul.ovf",
          InstructionHash = "mul.ovf",
          Description = "Multiply signed integer values. Signed result shall fit in same size",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xD9,
          Instruction = "mul.ovf.un",
          InstructionHash = "mul.ovf.un",
          Description = "Multiply unsigned integer values. Unsigned result shall fit in same size",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x65,
          Instruction = "neg",
          InstructionHash = "neg",
          Description = "Negate value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x8D,
          Instruction = "newarr <etype>",
          InstructionHash = "newarr",
          Description = "Create a new array with elements of type etype.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x73,
          Instruction = "newobj <ctor>",
          InstructionHash = "newobj",
          Description = "Allocate an uninitialized object or value type and call ctor.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE19,
          Instruction = "no. {\r\n typecheck,\r\n rangecheck,\r\n nullcheck\r\n }",
          InstructionHash = "no. {",
          Description = "The specified fault check(s) normally performed as part of the execution of the subsequent instruction can/shall be skipped.",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0x00,
          Instruction = "nop",
          InstructionHash = "nop",
          Description = "Do nothing (No operation).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x66,
          Instruction = "not",
          InstructionHash = "not",
          Description = "Bitwise complement (logical not).",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x60,
          Instruction = "or",
          InstructionHash = "or",
          Description = "Bitwise OR of two integer values, returns an integer.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x26,
          Instruction = "pop",
          InstructionHash = "pop",
          Description = "Pop value from the stack.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE1E,
          Instruction = "readonly.",
          InstructionHash = "readonly.",
          Description = "Specify that the subsequent array address operation performs no type check at runtime, and that it returns a controlled-mutability managed pointer",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0xFE1D,
          Instruction = "refanytype",
          InstructionHash = "refanytype",
          Description = "Push the type token stored in a typed reference.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xC2,
          Instruction = "refanyval <type>",
          InstructionHash = "refanyval",
          Description = "Push the address stored in a typed reference.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x5D,
          Instruction = "rem",
          InstructionHash = "rem",
          Description = "Remainder when dividing one value by another.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x5E,
          Instruction = "rem.un",
          InstructionHash = "rem.un",
          Description = "Remainder when dividing one unsigned value by another.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x2A,
          Instruction = "ret",
          InstructionHash = "ret",
          Description = "Return from method, possibly with a value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE1A,
          Instruction = "rethrow",
          InstructionHash = "rethrow",
          Description = "Rethrow the current exception.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x62,
          Instruction = "shl",
          InstructionHash = "shl",
          Description = "Shift an integer left (shifting in zeros), return an integer.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x63,
          Instruction = "shr",
          InstructionHash = "shr",
          Description = "Shift an integer right (shift in sign), return an integer.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x64,
          Instruction = "shr.un",
          InstructionHash = "shr.un",
          Description = "Shift an integer right (shift in zero), return an integer.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE1C,
          Instruction = "sizeof <typeTok>",
          InstructionHash = "sizeof",
          Description = "Push the size, in bytes, of a type as an unsigned int32.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0B,
          Instruction = "starg <uint16 (num)>",
          InstructionHash = "starg",
          Description = "Store value to the argument numbered num.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x10,
          Instruction = "starg.s <uint8 (num)>",
          InstructionHash = "starg.s",
          Description = "Store value to the argument numbered num, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xA4,
          Instruction = "stelem <typeTok>",
          InstructionHash = "stelem",
          Description = "Replace array element at index with the value on the stack",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9B,
          Instruction = "stelem.i",
          InstructionHash = "stelem.i",
          Description = "Replace array element at index with the i value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9C,
          Instruction = "stelem.i1",
          InstructionHash = "stelem.i1",
          Description = "Replace array element at index with the int8 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9D,
          Instruction = "stelem.i2",
          InstructionHash = "stelem.i2",
          Description = "Replace array element at index with the int16 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9E,
          Instruction = "stelem.i4",
          InstructionHash = "stelem.i4",
          Description = "Replace array element at index with the int32 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x9F,
          Instruction = "stelem.i8",
          InstructionHash = "stelem.i8",
          Description = "Replace array element at index with the int64 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xA0,
          Instruction = "stelem.r4",
          InstructionHash = "stelem.r4",
          Description = "Replace array element at index with the float32 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xA1,
          Instruction = "stelem.r8",
          InstructionHash = "stelem.r8",
          Description = "Replace array element at index with the float64 value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xA2,
          Instruction = "stelem.ref",
          InstructionHash = "stelem.ref",
          Description = "Replace array element at index with the ref value on the stack.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x7D,
          Instruction = "stfld <field>",
          InstructionHash = "stfld",
          Description = "Replace the value of field of the object obj with value.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xDF,
          Instruction = "stind.i",
          InstructionHash = "stind.i",
          Description = "Store value of type native int into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x52,
          Instruction = "stind.i1",
          InstructionHash = "stind.i1",
          Description = "Store value of type int8 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x53,
          Instruction = "stind.i2",
          InstructionHash = "stind.i2",
          Description = "Store value of type int16 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x54,
          Instruction = "stind.i4",
          InstructionHash = "stind.i4",
          Description = "Store value of type int32 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x55,
          Instruction = "stind.i8",
          InstructionHash = "stind.i8",
          Description = "Store value of type int64 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x56,
          Instruction = "stind.r4",
          InstructionHash = "stind.r4",
          Description = "Store value of type float32 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x57,
          Instruction = "stind.r8",
          InstructionHash = "stind.r8",
          Description = "Store value of type float64 into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x51,
          Instruction = "stind.ref",
          InstructionHash = "stind.ref",
          Description = "Store value of type object ref (type O) into memory at address",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE0E,
          Instruction = "stloc <uint16 (indx)>",
          InstructionHash = "stloc",
          Description = "Pop a value from stack into local variable indx.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0A,
          Instruction = "stloc.0",
          InstructionHash = "stloc.0",
          Description = "Pop a value from stack into local variable 0.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0B,
          Instruction = "stloc.1",
          InstructionHash = "stloc.1",
          Description = "Pop a value from stack into local variable 1.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0C,
          Instruction = "stloc.2",
          InstructionHash = "stloc.2",
          Description = "Pop a value from stack into local variable 2.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x0D,
          Instruction = "stloc.3",
          InstructionHash = "stloc.3",
          Description = "Pop a value from stack into local variable 3.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x13,
          Instruction = "stloc.s <uint8 (indx)>",
          InstructionHash = "stloc.s",
          Description = "Pop a value from stack into local variable indx, short form.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x81,
          Instruction = "stobj <typeTok>",
          InstructionHash = "stobj",
          Description = "Store a value of type typeTok at an address.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x80,
          Instruction = "stsfld <field>",
          InstructionHash = "stsfld",
          Description = "Replace the value of field with val.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0x59,
          Instruction = "sub",
          InstructionHash = "sub",
          Description = "Subtract value2 from value1, returning a new value.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xDA,
          Instruction = "sub.ovf",
          InstructionHash = "sub.ovf",
          Description = "Subtract native int from a native int. Signed result shall fit in same size",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xDB,
          Instruction = "sub.ovf.un",
          InstructionHash = "sub.ovf.un",
          Description = "Subtract native unsigned int from a native unsigned int. Unsigned result shall fit in same size.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0x45,
          Instruction = "switch <uint32, int32, int32 (t1..tN)>",
          InstructionHash = "switch",
          Description = "Jump to one of n values.",
          Type = "Base instruction"
      },
      new ILCode
        {
          Opcode = 0xFE14,
          Instruction = "tail.",
          InstructionHash = "tail.",
          Description = "Subsequent call terminates current method",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0x7A,
          Instruction = "throw",
          InstructionHash = "throw",
          Description = "Throw an exception.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE12,
          Instruction = "unaligned. (alignment)",
          InstructionHash = "unaligned. (alignment)",
          Description = "Subsequent pointer instruction might be unaligned.",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0x79,
          Instruction = "unbox <valuetype>",
          InstructionHash = "unbox",
          Description = "Extract a value-type from obj, its boxed representation.",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xA5,
          Instruction = "unbox.any <typeTok>",
          InstructionHash = "unbox.any",
          Description = "Extract a value-type from obj, its boxed representation",
          Type = "Object model instruction"
      },
      new ILCode
        {
          Opcode = 0xFE13,
          Instruction = "volatile.",
          InstructionHash = "volatile.",
          Description = "Subsequent pointer reference is volatile.",
          Type = "Prefix to instruction"
      },
      new ILCode
        {
          Opcode = 0x61,
          Instruction = "xor",
          InstructionHash = "xor",
          Description = "Bitwise XOR of integer values, returns an integer.",
          Type = "Base instruction"
      },
    };
  }
}
