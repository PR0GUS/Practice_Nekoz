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

    println!("\nTask 06 (Breaking the Records):");
    let scores = vec![10, 5, 20, 20, 4, 5, 2, 25, 1];
    let records = hackerrank::task06::breaking_records(&scores);
    println!("Records broken (Max, Min): {:?}", records);

    println!("\nTask 07 (Migratory Birds):");
    let birds = vec![1, 4, 4, 4, 5, 3];
    let most_frequent = hackerrank::task07::migratory_birds(&birds);
    println!("Most frequently sighted bird type ID: {}", most_frequent);

    println!("\nTask 08 (Sales by Match):");
    let socks = vec![10, 20, 20, 10, 10, 30, 50, 10, 20];
    let pairs = hackerrank::task08::sock_merchant(9, &socks);
    println!("Total matching pairs of socks: {}", pairs);
}