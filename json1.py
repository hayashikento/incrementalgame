import json
from collections import OrderedDict
import pprint
from attr import attributes
from matplotlib.pyplot import sca
from numpy import hamming
import pandas as pd
import matplotlib.pyplot as plt


with open('temp.json') as f:
    df = json.load(f)
    pprint.pprint(df, width=40)
    print(type(df))
print(df['Features'])

sf_Features = json.dumps(df['Features'])
print(sf_Features)

df_f = pd.read_json(sf_Features)

print(df_f)
corr_matrix = df_f.corr()
print(corr_matrix)
df_f.plot(kind="scatter", x="revenue", y="action", alpha=0.1)
plt.show()
