import pandas as pd

s = pd.date_range('20180101', periods=6)
s

print("%s" % (s))
pause = input("press any key to exit")