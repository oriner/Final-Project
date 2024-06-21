import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

# Load your data
data = pd.read_csv('blood_storage.csv')  

# Data Analysis
summary = data.describe()
print(summary)

# Plotting
sns.histplot(data['BloodType'])
plt.title('Distribution of Blood Types')
plt.savefig('blood_type_distribution.png')

# Save summary to a CSV
summary.to_csv('data_summary.csv')
