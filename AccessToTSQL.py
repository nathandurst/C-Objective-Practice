import re
import datetime
import os
import tkinter.filedialog as filedialog
import tkinter.messagebox as messagebox


def poundforupdate(new_line):
    insensitive_update = re.compile(re.escape('=update '), re.IGNORECASE)
    new_line = insensitive_update.sub('=UPDATE #', new_line)
    return new_line

def poundforjoin(new_line):
    insensitive_join = re.compile(re.escape(' join '), re.IGNORECASE)
    new_line = insensitive_join.sub(' JOIN #', new_line)
    return new_line

def poundfortable(new_line):
    insensitive_table = re.compile(re.escape( ' table '), re.IGNORECASE)
    new_line = insensitive_table.sub(' TABLE #', new_line)
    return new_line

def removecolumn(new_line):
    insensitive_column = re.compile(re.escape(' column '), re.IGNORECASE)
    new_line = insensitive_column.sub(' ', new_line)
    return new_line

def poundforfrom(new_line):
    insensitive_from = re.compile(re.escape(' from '), re.IGNORECASE)
    new_line = insensitive_from.sub(' FROM #', new_line)
    return new_line

def poundforinto(new_line):
    insensitive_into = re.compile(re.escape(' into '), re.IGNORECASE)
    new_line = insensitive_into.sub(' INTO #', new_line)
    return new_line

def convertiif(old_line):
    start = 0
    end = 0
    count = 0
    max = 0
    first_comma = 0
    for i in range(0, len(old_line)):
        temp = old_line[i:i + 3].upper()
        if old_line[i:i+4].upper() == 'IIF(':
            if count < 1:
                start = i
            count += 1
            max = count
        if start > 0 and old_line[i] == ')':
            count -= 1
            if (count == 0):
                end = i+1

    old_substring = (old_line[start:end])
    insensitive_iif = re.compile(re.escape('iif'), re.IGNORECASE)
    new_substring = insensitive_iif.sub('CASE ', old_substring)

    for i in range(0, max):
        new_substring = new_substring.replace(',', ' THEN ', 1)
        new_substring = new_substring.replace(',', ' ELSE ', 1)
        new_substring = new_substring.replace(')', ' END ', 1)
        new_substring = new_substring.replace('(', ' WHEN ', 1)

    new_line = old_line.replace(old_substring, new_substring)
    return new_line


def ShowFile():
    MsgBox = messagebox.askokcancel("Show converted report", "Would you like to open the converted report in your default file viewer?")
    return MsgBox


FILEOPENOPTIONS = [('WSO files', '*.wsr'), ('All files', '*')]
read_file_name = filedialog.askopenfilename(filetypes=FILEOPENOPTIONS)
r = open(read_file_name, "r")
time_append = datetime.datetime.now()
write_file_name = read_file_name[0:len(read_file_name) - 4] + time_append.strftime('%d%m%Y_%H%M%S') + ".wsr"
w = open(write_file_name, "w+")


r.seek(0)
count = 0
for line in r:
    # place pound sign in front of temp tables
    if re.search('=update', line, re.IGNORECASE):
        line = poundforupdate(line)
        line = poundforjoin(line)
        line = convertiif(line)
        # rearrange query for TSQL
        w.write(line)
    elif re.search('=alter', line, re.IGNORECASE):
        count = count + 1
        line = poundfortable(line)
        line = removecolumn(line)
        w.write(line)
    elif re.search('=select', line, re.IGNORECASE):
        count = count + 1
        line = poundforfrom(line)
        line = poundforinto(line)
        line = poundforjoin(line)
        w.write(line)
    elif re.search('=create', line, re.IGNORECASE):
        count = count + 1
        line = poundfortable(line)
        w.write(line)
    elif re.search('=insert', line, re.IGNORECASE):
        count = count + 1
        line = poundforinto(line)
        line = poundforjoin(line)
        w.write(line)
    else:
        w.write(line)

r.close();
w.close();

if ShowFile():
    os.startfile(write_file_name)
# pause = input("press any key to exit")
