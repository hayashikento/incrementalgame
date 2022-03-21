from cgi import MiniFieldStorage
import sklearn
from sklearn.datasets import fetch_openml
import matplotlib as mpl
import matplotlib.pyplot as plt
from sklearn.linear_model import SGDClassifier
import numpy as np
from sklearn import datasets

digits = datasets.load_digits()
mnist = fetch_openml('digits_64', version=1)

digits.keys()
X, y = digits["data"], digits["target"]
X.shape
y.shape

some_digit = X[0]
some_digit_image = some_digit.reshape(28, 28)

plt.imshow(some_digit_image, cmap="binary")
plt.axis("off")
plt.show()
y [0]
y = y.astype(np.uint8)
X_train, X_test, y_train, y_test = X[:54], X[54:], y[:54], y[54:]
y_train_5 = (y_train == 5)
y_test_5 = (y_test == 5)

sgd_clf = SGDClassifier(random_state=42)
sgd_clf.fit(X_train, y_train_5)
print(sgd_clf.predict([some_digit]))