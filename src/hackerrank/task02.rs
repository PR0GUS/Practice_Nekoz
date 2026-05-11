pub fn grading_students(grades: &[i32]) -> Vec<i32> {
    let mut result = Vec::new();

    for i in 0..grades.len() {
        let grade = grades[i];

        if grade < 38 {
            result.push(grade);
        } else {
            let rem = grade % 5;
            let diff = 5 - rem;

            if diff < 3 {
                result.push(grade + diff);
            } else {
                result.push(grade);
            }
        }
    }

    result
}

#[cfg(test)]
mod tests {
    use super::*; 
    #[test]
    fn check_my_grading() {
        let input = [74, 61, 36, 43];

        let output = grading_students(&input); 
        
        println!("Input: {:?}", input);
        println!("Output: {:?}", output);
        
        assert_eq!(output[0], 75);
    }
}