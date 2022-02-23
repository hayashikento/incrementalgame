import imp
import sklearn
from sklearn.datasets import fetch_openml
import matplotlib as mpl
import matplotlib.pyplot as plt
from sklearn.linear_model import SGDClassifier
import numpy as np
import pickle
from sklearn.model_selection import cross_val_score
from sklearn.svm import SVC
from sklearn.multiclass import OneVsRestClassifier
from sklearn.preprocessing import StandardScaler

save_file = 'mnist.pkl'
#mnist = fetch_openml('mnist_784', version=1)
#with open(save_file, 'wb') as f:
    #pickle.dump(mnist, f, -1)#

with open(save_file, 'rb') as f:
    mnist = pickle.load(f)






mnist.keys()
X, y = mnist["data"], mnist["target"]
X.shape
y.shape

some_digit = X[0]
some_digit_image = some_digit.reshape(28, 28)

plt.imshow(some_digit_image, cmap="binary")
plt.axis("off")
plt.show()
y [0]
y = y.astype(np.uint8)
X_train, X_test, y_train, y_test = X[:60000], X[60000:], y[:60000], y[60000:]
y_train_5 = (y_train == 5)
y_test_5 = (y_test == 5)

sgd_clf = SGDClassifier(random_state=42)
sgd_clf.fit(X_train, y_train_5)
print(sgd_clf.predict([some_digit]))

sgd_clf.fit(X_train, y_train)
print(sgd_clf.predict([some_digit]))

sgd_clf.decision_function([some_digit])

cross_val_score(sgd_clf, X_train, y_train, cv=3, scoring="accuracy")

scaler = StandardScaler()
X_train_scaled = scaler.fit_transform(X_train.astype(np.float64))
cross_val_score(sgd_clf, X_train, y_train, cv=3, scoring="accuracy")
