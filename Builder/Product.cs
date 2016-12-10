namespace DesignPatterns.Builder
{
    class Product
    {
        Part1 m_part1;
        Part2 m_part2;
        Part3 m_part3;

        public string Type { get; set; }
        public Part1 PART1 { get { return m_part1; } set { m_part1 = value; } }
        public Part2 PART2 { get { return m_part2; } set { m_part2 = value; } }
        public Part3 PART3 { get { return m_part3; } set { m_part3 = value; } }

        public override string ToString()
        {
            return "Part 1: " + m_part1 + "; part 2: " + m_part2 + "; part 3: " + m_part3;
        }
    }
}
