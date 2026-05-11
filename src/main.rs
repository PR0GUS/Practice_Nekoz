mod hackerrank;

fn main() {
    println!("We learn Rust!");

    hackerrank::task01::staircase(6);

    let my_grades = [74, 61, 36, 43]; 
    let result = hackerrank::task02::grading_students(&my_grades);

    println!("Rounded grades: {:?}", result);

    println!("\nApple and Orange:");
    let apples = [-2, 2, 1];
    let oranges = [5, -6];
    
    hackerrank::task03::apples_and_oranges(7, 11, 5, 15, &apples, &oranges);
}
