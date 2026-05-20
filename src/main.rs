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

    println!("\nTask 04 (Kangaroo):");
    let result_kanga = hackerrank::task04::kangaroo(0, 3, 4, 2);
    println!("Can they meet? {}", result_kanga);

    println!("\nTask 05 (Between Two Sets):");
    let a = vec![2, 4];
    let b = vec![16, 32, 96];
    let result_sets = hackerrank::task05::get_total_x(&a, &b);
    println!("Total numbers between sets: {}", result_sets);
}
