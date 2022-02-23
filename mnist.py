from sklearn.datasets import fetch_openml
from sklearn.linear_model import SGDClassifier
import numpy as np
import pickle
from sklearn.model_selection import cross_val_score


save_file = 'mnist.pkl'

with open(save_file, 'rb') as f:
    mnist = pickle.load(f)

X, y = mnist["data"], mnist["target"]


some_digit = X[0]

y = y.astype(np.uint8)
X_train, X_test, y_train, y_test = X[:60000], X[60000:], y[:60000], y[60000:]

sgd_clf = SGDClassifier(random_state=42)
sgd_clf.fit(X_train, y_train)
print(sgd_clf.predict([some_digit]))
