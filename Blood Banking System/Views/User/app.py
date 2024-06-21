from flask import Flask, request, jsonify
import pandas as pd
from sklearn.linear_model import LinearRegression

app = Flask(__name__)

# Load your model
model = LinearRegression()
model.fit([[1, 2], [2, 3], [3, 4]], [1, 2, 3])  

@app.route('/predict', methods=['POST'])
def predict():
    data = request.get_json()
    df = pd.DataFrame(data)
    prediction = model.predict(df)
    return jsonify(prediction.tolist())

if __name__ == '__main__':
    app.run(debug=True)
