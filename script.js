function calculateBMI(){

    // Get the values from the input fields
    const weight = document.getElementById('weight').value;
    const height = document.getElementById('height').value;
    
    // Determine the BMI category
    let category = '';
    if(weight > 0 && height > 0){
        // Calculate BMI
        const bmi = weight / (height * height);
        if (bmi < 18.5) {
            category = `Underweight: ${bmi.toFixed(2)}`;
        } else if (bmi >= 18.5 && bmi < 24.9) {
            category = `Normal weight: ${bmi.toFixed(2)}`;
        } else if (bmi >= 25 && bmi < 29.9) {
            category = `Overweight: ${bmi.toFixed(2)}`;
        } else {
            category = `Obesity: ${bmi.toFixed(2)}`;
        }
    }else{
        category = 'Please enter valid weight and height';
    }

    // Display the result
    document.getElementById('result').textContent = category;
};
