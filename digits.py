from sklearn import datasets
digits = datasets.load_digits()
from sklearn import datasets
import matplotlib.pyplot as plt
import numpy as np
from sklearn import decomposition
from mpl_toolkits.mplot3d import Axes3D
from sklearn import svm, metrics
import sklearn.svm as svm
from sklearn.metrics import confusion_matrix
from sklearn.metrics import classification_report

print(digits.data)
print('次元:',digits.data.ndim)
print(digits.target)
digits.images[2]

plt.imshow(digits.images[-1], cmap=plt.cm.gray_r, interpolation='nearest')
plt.show()

rows_count = 4
columns_count = 4
graphs_count = rows_count * columns_count
axes = []
x = np.linspace(-1, 1, 10)
fig = plt.figure(figsize=(12,9))
for i in range(1, graphs_count + 1):
     axes.append(fig.add_subplot(rows_count, columns_count, i))
     axes[i-1].imshow(digits.images[i],interpolation='bicubic', cmap='viridis')
fig.subplots_adjust(wspace=0.3, hspace=0.3)
plt.show()

digits = datasets.load_digits()

all_features =digits.data
teacher_labels = digits.target
def getcolor(c):
    if c==0:
        return 'red'
    elif c==1:
        return 'orange'
    elif c==2:
        return 'yellow'
    elif c==3:
        return 'greenyellow'
    elif c==4:
        return 'green'
    elif c==5:
        return 'cyan'
    elif c==6:
        return 'blue'
    elif c==7:
        return 'navy'
    elif c==8:
        return 'purple'
    else:
        return 'black'

pca = decomposition.PCA(n_components=3)
three_features = pca.fit_transform(all_features)
fig = plt.figure(figsize=(12,9))
ax = fig.add_subplot(111,projection='3d')
colors = list(map(getcolor, teacher_labels))
ax.scatter(three_features[:,0], three_features[:,1], three_features[:,2], color=colors)
plt.show()

images_and_labels = list(zip(digits.images, digits.target))
print('教師データ:',digits.target)
fig = plt.figure(figsize=(12,9))
for index, (image,label) in enumerate(images_and_labels[:8]):
    plt.subplot(2, 4, index + 1)
    plt.axis('off')
    plt.imshow(image, cmap=plt.cm.gray_r, interpolation='nearest')
    plt.title('Train Data: %i' % label)
num_samples = len(digits.images)
print(num_samples)

data = digits.images.reshape((num_samples,-1))
model = svm.SVC(gamma=0.001)

train_features=data[:num_samples // 2]
train_teacher_labels=digits.target[:num_samples // 2]

test_feature=data[num_samples // 2:]
test_teacher_labels=digits.target[num_samples // 2:]

model.fit(train_features,train_teacher_labels)

expected = test_teacher_labels
predicted = model.predict(test_feature)

print("分類機からの分類結果 %s: \n %s \n"
      % (model, classification_report(expected, predicted)))
print("コンフュージョンマトリックス:\n %s" % confusion_matrix(expected, predicted))

fig = plt.figure(figsize=(12,9)) 
#
images_and_predictions = list(zip(digits.images[num_samples // 2:], predicted))
for index, (image, prediction) in enumerate(images_and_predictions[:4]):
    plt.subplot(2, 4, index + 5)
    plt.imshow(image, cmap='PiYG', interpolation='bicubic')
    plt.title('Prediction: %i' % prediction)

plt.show()