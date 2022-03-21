from django import http
from flask import Flask, jsonify, request
import pickle
import pandas as pd
import json


app = Flask(__name__)


app.config['JSON_AS_ASCII'] = False


@app.route('/', methods=["GET", "POST"])
def get_json():
    data = request.get_json()
    print(data)
    filename = 'sgd_clf.sav'
    loaded_model = pickle.load(open(filename, 'rb'))
    df_f = pd.DataFrame(data,index=['i',])
    X = df_f.drop(['action', 'datetime'], axis=1)
    print(X.shape)

    action = loaded_model.predict(X)
    print(action[0])
    return jsonify({
        "Result": 1,
        "Action" : int(action[0])
    })

if __name__ == '__main__':

    app.run(debug=False, host="0.0.0.0", port="5000")
