from sklearn.datasets import fetch_openml
from sklearn.linear_model import SGDClassifier
import numpy as np
import pickle
from sklearn.model_selection import cross_val_score
import json
import pandas as pd

with open('temp.json') as f:
    df = json.load(f)
sf_Features = json.dumps(df['Features'])
df_f = pd.read_json(sf_Features)
print(df_f)
y = df_f['action']
X = df_f.drop(['action', 'datetime'], axis=1)
print(X.shape)
print(y.shape)

df_f = df_f.reset_index()

some_digit = X.iloc[0]

y = y.astype(np.uint8)
X_train, X_test, y_train, y_test = X[:200], X[200:], y[:200], y[200:]

sgd_clf = SGDClassifier(random_state=42)
sgd_clf.fit(X_train, y_train)
print(sgd_clf.predict([some_digit]))

filename = 'sgd_clf.sav'
pickle.dump(sgd_clf, open(filename, 'wb'))

loaded_model = pickle.load(open(filename, 'rb'))
result = loaded_model.score(X_test, y_test)
print(result)