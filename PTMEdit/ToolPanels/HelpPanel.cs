using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTMEdit
{
    public partial class HelpPanel : UserControl
    {
        public HelpPanel(Control parent)
        {
            InitializeComponent();
            Parent = parent;
            Parent.Text = "Help";
            Dock = DockStyle.Fill;

            InitCommands();
            LstTopics.Sorting = SortOrder.Ascending;
            LstTopics.Sort();
            LstTopics.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            LstTopics.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LstTopics_Click(object sender, EventArgs e)
        {
            if (LstTopics.SelectedItems.Count == 0)
                return;

            var item = LstTopics.SelectedItems[0];
            string cmd = item.SubItems[0].Text;
            string param = item.SubItems[1].Text;
            string desc = (string)item.Tag;

            TxtHelp.Text = $"{cmd}   {param}";
            TxtHelp.Text += Environment.NewLine + Environment.NewLine;
            TxtHelp.Text += desc;
        }

        private void AddCommand(string cmd, string param, string description, string extDesc = null)
        {
            if (extDesc != null)
                description += Environment.NewLine + Environment.NewLine + extDesc;

            var item = new ListViewItem(new string[] { cmd, param });
            item.Tag = description;
            LstTopics.Items.Add(item);
        }

        private void InitCommands()
        {
            AddCommand("NOP", "", "Do nothing for 1 machine cycle");
            AddCommand("INCL", "path", "Include another PTML source code file");
            AddCommand("EXIT", "", "Terminate program and close window");
            AddCommand("RESET", "", "Restart program and machine");
            AddCommand("TITLE", "text", "Set window title");
            AddCommand("CYCLES", "dest", "Get number of cycles elapsed since machine started");
            AddCommand("HALT", "", "Terminate program but keep window open");
            AddCommand("GOTO", "label", "Branch execution to code starting from label");
            AddCommand("CALL", "label", "Call subroutine starting from label");
            AddCommand("RET", "", "Return from subroutine");
            AddCommand("PAUSE", "cycles", "Pause program execution for the specified number of machine cycles");
            AddCommand("FOR", "var, first, last, step?", "Start an execution loop");
            AddCommand("NEXT", "", "End a FOR loop");
            AddCommand("BRK", "", "Exit early from FOR loop");
            AddCommand("SKIP", "", "Skip current FOR loop iteration");
            AddCommand("IF.EQ", "a, b", "Execute block only if a = b");
            AddCommand("IF.NEQ", "a, b", "Execute block only if a <> b");
            AddCommand("IF.GT", "a, b", "Execute block only if a > b");
            AddCommand("IF.GTE", "a, b", "Execute block only if a >= b");
            AddCommand("IF.LT", "a, b", "Execute block only if a < b");
            AddCommand("IF.LTE", "a, b", "Execute block only if a >= b");
            AddCommand("IF.KEY", "keyname", "Execute block only if specified key is pressed");
            AddCommand("ENDIF", "", "End an IF block");
            AddCommand("VAR", "name, value", "Set a variable");
            AddCommand("DEF", "name, value", "Define a constant");
            AddCommand("ARR.NEW", "name, len?", "Create a new array with optional length");
            AddCommand("ARR.PUSH", "arr, value", "Insert new element into array with value");
            AddCommand("ARR.LEN", "arr, var", "Get array length");
            AddCommand("ARR.SET", "arr[index], value", "Set value of element at array index");
            AddCommand("ARR.ERASE", "arr, index", "Erase element at array index");
            AddCommand("ARR.CLR", "arr", "Delete all elements from array");
            AddCommand("ARR.COPY", "src, dest", "Copy all elements from one array to another");
            AddCommand("ARR.FOR", "arr, iter", "Iterate through all elements of an array");
            AddCommand("RND", "var, min, max", "Generate a random number between min and max");
            AddCommand("INC", "var", "Increment variable by 1");
            AddCommand("DEC", "var", "Decrement variable by 1");
            AddCommand("ADD", "dest, a, b", "Set variable to a plus b");
            AddCommand("SUB", "dest, a, b", "Set variable to a minus b");
            AddCommand("MUL", "dest, a, b", "Set variable to a multiplied by b");
            AddCommand("TILE.NEW", "char?, fgc?, bgc?", "Start new tile with character");
            AddCommand("TILE.ADD", "char, fgc, bgc", "Add character to tile");
            AddCommand("TILE.SETC", "ix, char", "Set tile character at index");
            AddCommand("TILE.SETF", "ix, fgc", "Set tile foreground color at index");
            AddCommand("TILE.SETB", "ix, bgc", "Set tile background color at index");
            AddCommand("TILE.COLOR", "ix, fgc, bgc", "Set tile foreground and background colors at index");
            AddCommand("TILE.GETC", "var, ix", "Get tile character at index");
            AddCommand("TILE.GETF", "var, ix", "Get tile foreground color at index");
            AddCommand("TILE.GETB", "var, ix", "Get tile background color at index");
            AddCommand("TILE.PARSE", "str", "Parse tile definition from string in the format: char1,fgc1,bgc1;char2,fgc2,bgc2,...");
            AddCommand("TILE.STORE", "id", "Store tile definition");
            AddCommand("TILE.LOAD", "id", "Load tile definition");
            AddCommand("TILE.SETP", "prop, value", "Set tile property");
            AddCommand("TILE.GETP", "var, prop", "Get tile property");
            AddCommand("LAYER", "ix", "Select layer in current buffer");
            AddCommand("LOCATE", "x, y", "Select cursor position in current buffer layer");
            AddCommand("CSR.X", "x", "Set column of cursor in current buffer layer");
            AddCommand("CSR.Y", "y", "Set row of cursor in current buffer layer");
            AddCommand("CSR.MOV", "dx, dy", "Move cursor for the specified distance");
            AddCommand("CSR.GETX", "var", "Get cursor column");
            AddCommand("CSR.GETY", "var", "Get cursor row");
            AddCommand("CSR.R", "dist?", "Move cursor right");
            AddCommand("CSR.L", "dist?", "Move cursor left");
            AddCommand("CSR.U", "dist?", "Move cursor up");
            AddCommand("CSR.D", "dist?", "Move cursor down");
            AddCommand("CSR.UR", "dist?", "Move cursor up/right");
            AddCommand("CSR.UL", "dist?", "Move cursor up/left");
            AddCommand("CSR.DR", "dist?", "Move cursor down/right");
            AddCommand("CSR.DL", "dist?", "Move cursor down/left");
            AddCommand("BUF.NEW", "id, cols, rows, layers", "Create new tile buffer");
            AddCommand("BUF.SEL", "id", "Select tile buffer");
            AddCommand("BUF.SHOW", "", "Show selected tile buffer");
            AddCommand("BUF.HIDE", "", "Hide selected tile buffer");
            AddCommand("BUF.VIEW", "x, y, cols, rows", "Configure viewport for selected tile buffer");
            AddCommand("BUF.SCRL", "dx, dy", "Scroll viewport over selected tile buffer");
            AddCommand("BUF.COLS", "var", "Get number of columns in selected tile buffer");
            AddCommand("BUF.ROWS", "var", "Get number of rows in selected tile buffer");
            AddCommand("PUT", "", "Put current tile at current cursor position in selected tile buffer layer");
            AddCommand("GET", "", "Copy tile at current cursor position in selected tile buffer layer into current tile");
            AddCommand("DEL", "", "Delete tile at current cursor position in selected tile buffer layer");
            AddCommand("PUT.R", "dist?", "Put current tile then move right");
            AddCommand("PUT.L", "dist?", "Put current tile then move left");
            AddCommand("PUT.U", "dist?", "Put current tile then move up");
            AddCommand("PUT.D", "dist?", "Put current tile then move down");
            AddCommand("PUT.UR", "dist?", "Put current tile then move up/right");
            AddCommand("PUT.UL", "dist?", "Put current tile then move up/left");
            AddCommand("PUT.DR", "dist?", "Put current tile then move down/right");
            AddCommand("PUT.DL", "dist?", "Put current tile then move down/left");
            AddCommand("RECT", "x, y, cols, rows", "Fill with current tile the rectangle area in selected buffer layer");
            AddCommand("FILL", "", "Fill entire selected buffer layer with current tile");
            AddCommand("CLS", "", "Clear all layers in selected buffer");
            AddCommand("CLL", "", "Clear specified layer in selected buffer");
            AddCommand("CLR", "x, y, cols, rows", "Clear specified rectangle area in selected buffer layer");
            AddCommand("MOV", "dx, dy", "Move tile at current cursor position for the specified distance");
            AddCommand("MOVB", "x, y, cols, rows, dx, dy", "Move all tiles in specified rectangle area for the specified distance");
            AddCommand("DRAW", "seq", "Draw a sequence of tiles according to the specified string", GetExtDescForDraw());
            AddCommand("PRINT", "str", "Print text at current cursor position in selected buffer layer, then move cursor right", GetExtDescForPrint());
            AddCommand("PRINT.ADD", "str", "Print text over existing text at current cursor position in selected buffer layer, then move cursor right", GetExtDescForPrint());
            AddCommand("PRINTL", "str", "Print text at current cursor position in selected buffer layer, then move cursor to next line", GetExtDescForPrint());
            AddCommand("PRINTR", "str", "Print raw text at current cursor position in selected buffer layer, then move cursor right");
            AddCommand("PUTC", "char", "Put character at current cursor position in selected buffer layer");
            AddCommand("WCOL", "bgc", "Select background color of window");
            AddCommand("FCOL", "fgc", "Select foreground color of text");
            AddCommand("BCOL", "bgc", "Select background color of text");
            AddCommand("COLOR", "fgc, bgc?", "Select foreground (and optionally background) color of text");
            AddCommand("VSYNC", "", "Force screen refresh");
            AddCommand("TRON", "", "Enable tile transparency");
            AddCommand("TROFF", "", "Disable tile transparency");
            AddCommand("CHR", "ix, row, pixels", "Define the byte representing pixels in the given row for the specified character (from 0 to 7 inclusive)");
            AddCommand("CHRS", "ix, row0, ..., row7", "Define the 8 bytes representing pixels for each character row (from 0 to 7 inclusive)");
            AddCommand("CHR.LEN", "var", "Get number of characters in tileset");
            AddCommand("CHR.GETBS", "var, ix", "Get tile pixels as binary string");
            AddCommand("CHR.SETBS", "ix, str", "Parse tile pixels from binary string");
            AddCommand("CHR.NEWPG", "pages", "Add a new page in tileset with 256 blank characters");
            AddCommand("PAL", "ix, rgb", "Set RGB color in the specified palette index");
            AddCommand("PAL.LEN", "var", "Get number of colors in the palette");
            AddCommand("PAL.CLR", "", "Set all colors in the palette to a blank color");
            AddCommand("PAL.GET", "var, ix", "Get RGB color (&hRRGGBB) at the specified palette index");
            AddCommand("PAL.GETR", "var, ix", "Get red component (0-255) of color at the specified palette index");
            AddCommand("PAL.GETG", "var, ix", "Get green component (0-255) of color at the specified palette index");
            AddCommand("PAL.GETB", "var, ix", "Get blue component (0-255) of color at the specified palette index");
            AddCommand("PAL.SETR", "ix, value", "Set red component (0-255) of color at the specified palette index");
            AddCommand("PAL.SETG", "ix, value", "Set green component (0-255) of color at the specified palette index");
            AddCommand("PAL.SETB", "ix, value", "Set blue component (0-255) of color at the specified palette index");
            AddCommand("INPUT", "var, maxlen", "Wait for user to type some text, then store it in a variable once ENTER key is pressed");
            AddCommand("INKEY", "var", "Get name of key currently pressed on the keyboard", GetExtDescForInkey());
            AddCommand("KCODE", "var", "Get code of key currently pressed on the keyboard");
            AddCommand("DBG.BRK", "", "Interrupt machine for debugging");
            AddCommand("DBG.DUMP", "", "Dump machine info to file");
            AddCommand("DBG.PERF", "", "Enable performance monitor");
            AddCommand("DBG.MSG", "text", "Show a popup alert message box for debugging purposes");
            AddCommand("PLAY", "seq", "Play a sequence of musical notes (only once)", GetExtDescForPlay());
            AddCommand("LPLAY", "seq", "Play a sequence of musical notes (repeatedly on loop)", GetExtDescForPlay());
            AddCommand("SOUND", "freq, len", "Play musical note of specified frequence for given length");
            AddCommand("VOL", "value", "Set sound volume");
            AddCommand("QUIET", "", "Stop all sounds");
            AddCommand("CLOAD", "path, var", "Read all text from file into variable");
            AddCommand("BLOAD", "path, arr", "Read all bytes from file into array");
            AddCommand("CSAVE", "path, str", "Write all text from variable into file");
            AddCommand("BSAVE", "path, arr", "Write all bytes from array into file");
            AddCommand("FILE.CHK", "path, var", "Check if given file exists, then set variable to 1 (if it exists) or 0 (if it does not exist)");
            AddCommand("STR.FMT", "dest, fmt, value", "Convert a number to string using the given format");
            AddCommand("STR.SUB", "dest, str, begin, end", "Get substring between the given indexes");
            AddCommand("STR.LEN", "dest, str", "Get length of string");
            AddCommand("STR.REPT", "dest, count, str", "Repeat string");
            AddCommand("STR.CAT", "dest, a, b", "Concatenate strings");
            AddCommand("STR.SPLIT", "arr, str, sep", "Split string into array at the given delimiter");
            AddCommand("STR.TRIM", "dest, str", "Remove leading and trailing whitespaces from string");
            AddCommand("STR.UCASE", "dest, str", "Transform all characters in string to uppercase");
            AddCommand("STR.LCASE", "dest, str", "Transform all characters in string to lowercase");
            AddCommand("STR.REPL", "dest, str, old, new", "Replace all ocurrences of a substring with another string");
            AddCommand("STR.AT", "dest, str, index", "Get character at given string index");
            AddCommand("STR.IX", "dest, str, char", "Find index of given character in string");
            AddCommand("STR.START", "dest, str, prefix", "Check if string starts with the given prefix, then set variable to 1 (yes) or 0 (no)");
            AddCommand("STR.END", "dest, str, suffix", "Check if string ends with the given suffix, then set variable to 1 (yes) or 0 (no)");
            AddCommand("STR.HAS", "dest, str, find", "Check if string contains the given substring, then set variable to 1 (yes) or 0 (no)");
            AddCommand("WINDOW", "cols, rows, layers, zoom", "Override default tile buffer size and window dimensions");
            AddCommand("DIV", "dest, a, b", "Set variable to a divided by b");
            AddCommand("DIVR", "dest, a, b", "Set variable to remainder of a divided by b");
            AddCommand("POW", "dest, a, b", "Set variable to a to the power b");
            AddCommand("SQRT", "dest, a", "Set variable to square root of a");
            AddCommand("DATA", "item1, item2, ...", "Insert raw data at compile time");
            AddCommand("READ", "var", "Read value at current data pointer into variable then advance data pointer to next item");
            AddCommand("RESTORE", "", "Reset data pointer back to first item");
            AddCommand("IF.CALL", "var,value,label", "Call subroutine starting from label if variable is equal to value");
            AddCommand("IF.GOTO", "var,value,label", "Branch execution to code starting from label if variable is equal to value");
        }

        private string GetExtDescForPlay()
        {
            StringBuilder desc = new StringBuilder();

            desc.AppendLine("Sub-commands & notes (all subcommands/notes must be stringed together with no separators):" + Environment.NewLine);

            desc.AppendLine("O = select octave (0 ... 8)");
            desc.AppendLine("L = select tone length");
            desc.AppendLine("P = pause for specified length");
            desc.AppendLine("C");
            desc.AppendLine("C#");
            desc.AppendLine("D");
            desc.AppendLine("D#");
            desc.AppendLine("E");
            desc.AppendLine("F");
            desc.AppendLine("F#");
            desc.AppendLine("G");
            desc.AppendLine("G#");
            desc.AppendLine("A");
            desc.AppendLine("A#");
            desc.AppendLine("B");

            return desc.ToString();
        }

        private string GetExtDescForInkey()
        {
            StringBuilder desc = new StringBuilder();

            desc.AppendLine("Recognized key names:" + Environment.NewLine);

            desc.AppendLine("NONE = no key");
            desc.AppendLine("RIGHT = right arrow");
            desc.AppendLine("LEFT = left arrow");
            desc.AppendLine("UP = up arrow");
            desc.AppendLine("DOWN = down arrow");
            desc.AppendLine("SPACE = spacebar");
            desc.AppendLine("ENTER = enter/return");
            desc.AppendLine("ESC = escape");
            desc.AppendLine("TAB = tab");
            desc.AppendLine("BS = backspace");
            desc.AppendLine("INS = insert");
            desc.AppendLine("DEL = delete");
            desc.AppendLine("HOME = home");
            desc.AppendLine("END = end");
            desc.AppendLine("PGUP = page up");
            desc.AppendLine("PGDN = page down");
            desc.AppendLine("F1 ... F12 = function keys");
            desc.AppendLine("A ... Z = alphabetical keys");
            desc.AppendLine("0 ... 9 = digit keys");

            return desc.ToString();
        }

        private string GetExtDescForPrint()
        {
            StringBuilder desc = new StringBuilder();

            desc.AppendLine("Recognized escape sequences:" + Environment.NewLine);

            desc.AppendLine("{C} = print tile of specified index");
            desc.AppendLine("{F} = set foreground color");
            desc.AppendLine("{B} = set background color");
            desc.AppendLine("{/F} = revert foreground color");
            desc.AppendLine("{/B} = revert background color");
            desc.AppendLine("{%var} = print value of variable");
            desc.AppendLine("\\n = new line");

            return desc.ToString();
        }

        private string GetExtDescForDraw()
        {
            StringBuilder desc = new StringBuilder();

            desc.AppendLine("Sub-commands (individual subcommands must be separated by a blank space character):" + Environment.NewLine);

            desc.AppendLine("F = Select foreground color");
            desc.AppendLine("B = Select background color");
            desc.AppendLine("C = Select character");
            desc.AppendLine("X = Set cursor column");
            desc.AppendLine("Y = Set cursor row");
            desc.AppendLine("P = Enable drawing (put tiles as cursor moves)");
            desc.AppendLine("M = Disable drawing (only move cursor)");
            desc.AppendLine("R = Move cursor right");
            desc.AppendLine("L = Move cursor left");
            desc.AppendLine("U = Move cursor up");
            desc.AppendLine("D = Move cursor down");

            return desc.ToString();
        }
    }
}
